﻿using HttpTestTool.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HttpTestTool.Core
{
    public class RPSSchedulerService
    {
        private RequestModel _request;
        private int _count;
        private int _totalSecond;

        private Action<string> _console;

        private bool _isRunning;
        private readonly CancellationTokenSource _cancellation = new CancellationTokenSource();
        private CancellationToken _cancellationToken;

        private ConcurrentBag<CounterModel> _counter;
        public RPSSchedulerService(RequestModel request, int count, int totalSecond, Action<string> console)
        {
            _request = request;
            _count = count;
            _totalSecond = totalSecond;
            _console = console;

            _cancellationToken = _cancellation.Token;
            _cancellationToken.Register(() => { _console("正在停止..."); });
        }
        public void Start()
        {
            if (!_isRunning)
            {
                Task.Run(() =>
                {
                    _isRunning = true;
                    DoWork();
                });
            }
        }

        public void Stop()
        {
            if (_isRunning)
            {
                _cancellation.Cancel();
                _isRunning = false;
            }
        }

        private void DoWork()
        {
            _counter = new ConcurrentBag<CounterModel>();
            for (int i = 0; i < _totalSecond; i++)
            {
                if (!_isRunning)
                    break;
                for (int j = 0; j < _count; j++)
                {
                    if (!_isRunning)
                        break;
                    Task.Run(() =>
                    {
                        try
                        {
                            _cancellationToken.ThrowIfCancellationRequested();
                            Request();
                        }
                        catch (Exception ex)
                        {
                            if (ex is OperationCanceledException)
                            {
                                return;
                            }
                        }
                    });
                }
                Thread.Sleep(1000);
            }
            _console("已停止");
            Count();
        }

        private void Request()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var response = HttpBuilder.Handle(_request);
            sw.Stop();
            if (_isRunning)
            {
                var log = string.Format("线程{2}: Http状态码：{0}，耗时：{1}毫秒", response.StatusCode, sw.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                _console(log);
                //计数器
                _counter.Add(new CounterModel()
                {
                    ThreadId = Thread.CurrentThread.ManagedThreadId,
                    MilliSeconds = sw.ElapsedMilliseconds,
                    Response = response
                });
            }

        }

        private void Count()
        {
            var codeGroup = _counter.GroupBy(x => x.Response.StatusCode);
            var codeGroupList = new List<string>();
            foreach (var item in codeGroup)
            {
                codeGroupList.Add(string.Format("[{0}]:{1}", item.Key, item.Count()));
            }
            _console("Http状态码统计：" + string.Join("，", codeGroupList));
            var total = _counter.Count;
            var avgElapsed = _counter.Average(x => x.MilliSeconds);
            _console(string.Format("总请求数：{0}，平均耗时：{1}ms", total, avgElapsed.ToString("0.000")));
        }


    }
}
