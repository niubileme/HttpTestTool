using HttpTestTool.Models;
using System;
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
        private int _totalTime;

        private Action<string> _console;
        private Timer _timer;

        public RPSSchedulerService(RequestModel request, int count, int totalTime, Action<string> console)
        {
            _request = request;
            _count = count;
            _totalTime = totalTime;
            _console = console;

            _timer = new Timer(TimerAction, null, Timeout.Infinite, 1000);
        }

        private void TimerAction(object obj)
        {
            Parallel.For(0, _count, index =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var response = HttpBuilder.Handle(_request);
                sw.Stop();
                var log = string.Format("线程[{2}] Http状态码：{0}，耗时：{1}毫秒", response.StatusCode, sw.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                _console(log);

            });

            //for (int i = 0; i < _count; i++)
            //{
            //    var t = new Thread(() =>
            //    {
            //        try
            //        {
            //            Stopwatch sw = new Stopwatch();
            //            sw.Start();
            //            var response = HttpBuilder.Handle(_request);
            //            sw.Stop();
            //            var log = string.Format("线程[{2}] Http状态码：{0}，耗时：{1}毫秒", response.StatusCode, sw.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
            //            _console(log);
            //        }
            //        catch (Exception ex)
            //        {
            //            var log = string.Format("线程[{0}] {1}", Thread.CurrentThread.ManagedThreadId, ex.Message);
            //            _console(log);
            //        }
            //    });
            //    t.IsBackground = true;
            //    t.Start();
            //}
        }


        public void Start()
        {
            if (_timer != null)
                _timer.Change(0, 1000);
        }

        public void Stop()
        {
            if (_timer != null)
                _timer.Change(Timeout.Infinite, 1000);
        }
    }
}
