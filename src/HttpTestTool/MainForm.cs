using HttpTestTool.Core;
using HttpTestTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTestTool
{
    public partial class MainForm : Form
    {
        private RPSSchedulerService _RPSService;
        private VUSchedulerService _VUService;
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbb_RequestMethod.SelectedIndex = 0;
            txt_RequestTimeOut.Text = "5000";
            cb_AutoRedirect.Checked = true;
            cb_KeepAlive.Checked = true;

            txt_RPS_Count.Text = "5";
            txt_RPS_TotalTime.Text = "1";
            txt_VU_UserCount.Text = "3";
            txt_VU_Interval.Text = "2000";
            txt_VU_TotalTime.Text = "1";

            rb_RPS.Checked = true;
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;

        }

        private void btn_RequestTest_Click(object sender, EventArgs e)
        {
            var request = ValidateRequestParameter();
            if (request != null)
            {
                var response = HttpBuilder.Handle(request);
                TestConsoleLog(response);
            }
        }

        private RequestModel ValidateRequestParameter()
        {
            RequestModel request = new RequestModel();
            request.Url = rtxt_Url.Text;
            if (string.IsNullOrWhiteSpace(request.Url))
            {
                MessageBox.Show("Url不能为空");
                return null;
            }
            request.Method = cbb_RequestMethod.SelectedItem.ToString();
            var timeOut = 0;
            if (!int.TryParse(txt_RequestTimeOut.Text, out timeOut))
            {
                MessageBox.Show("超时时间错误");
                return null;
            }
            request.TimeOut = timeOut;
            request.AutoRedirect = cb_AutoRedirect.Checked;
            request.KeepAlive = cb_KeepAlive.Checked;

            request.Headers = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(rtxt_RequestHeaders.Text))
            {
                var headers = rtxt_RequestHeaders.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var header in headers)
                {
                    if (!string.IsNullOrWhiteSpace(header))
                    {
                        var item = header.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                        if (!string.IsNullOrWhiteSpace(item[0]) && !string.IsNullOrWhiteSpace(item[1]))
                            request.Headers.Add(item[0], item[1]);
                    }
                }
            }

            request.Datas = rtxt_RequestBody.Text;

            return request;
        }

        public void TestConsoleLog(ResponseModel response)
        {
            rtxt_Console.Invoke(new Action<ResponseModel>(x =>
            {
                rtxt_Console.Clear();
                var log = string.Format("Status:{0}\r\n", x.StatusCode);
                log += x.Response;
                rtxt_Console.AppendText(log);
            }), response);
        }

        public void ConsoleLog(string msg)
        {
            rtxt_Console.Invoke(new Action<string>(x =>
            {
                rtxt_Console.AppendText(string.Format("[{0}]{1}\r\n", DateTime.Now.ToString("HH:mm:ss"), x));
                rtxt_Console.ScrollToCaret();
            }), msg);
        }

        public void ClearConsole()
        {
            rtxt_Console.Invoke(new Action(() =>
            {
                rtxt_Console.Clear();
            }));
        }

        public void UIEnabled(bool isStart)
        {
            btn_Start.Enabled = !isStart;
            btn_Stop.Enabled = isStart;
            rb_RPS.Enabled = !isStart;
            rb_VU.Enabled = !isStart;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            var request = ValidateRequestParameter();
            if (request != null)
            {
                if (rb_RPS.Checked)
                {
                    int count = 0;
                    if (!int.TryParse(txt_RPS_Count.Text, out count))
                    {
                        MessageBox.Show("每秒发送次数错误");
                        return;
                    }
                    int total = 0;
                    if (!int.TryParse(txt_RPS_TotalTime.Text, out total))
                    {
                        MessageBox.Show("持续时长错误");
                        return;
                    }
                    ClearConsole();
                    _RPSService = new RPSSchedulerService(request, count, total * 60, ConsoleLog);
                    _RPSService.Start();
                }
                else if (rb_VU.Checked)
                {
                    int user = 0;
                    if (!int.TryParse(txt_VU_UserCount.Text, out user))
                    {
                        MessageBox.Show("模拟用户数量错误");
                        return;
                    }
                    int interval = 0;
                    if (!int.TryParse(txt_VU_Interval.Text, out interval))
                    {
                        MessageBox.Show("持续时长错误");
                        return;
                    }
                    int total = 0;
                    if (!int.TryParse(txt_VU_TotalTime.Text, out total))
                    {
                        MessageBox.Show("持续时长错误");
                        return;
                    }
                    ClearConsole();
                    _VUService = new VUSchedulerService(request, user, interval, total * 60, ConsoleLog);
                    _VUService.Start();
                }

                UIEnabled(true);
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            rb_RPS.Invoke(new Action(() =>
            {
                if (rb_RPS.Checked)
                {
                    if (_RPSService != null)
                        _RPSService.Stop();
                }
                else if (rb_VU.Checked)
                {
                    if (_VUService != null)
                        _VUService.Stop();
                }
                UIEnabled(false);
            }));

        }
    }
}
