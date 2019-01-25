using HttpTestTool.Core;
using HttpTestTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTestTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbb_RequestMethod.SelectedIndex = 0;
            txt_RequestTimeOut.Text = "5000";
            cb_AutoRedirect.Checked = true;
            cb_KeepAlive.Checked = true;
        }

        private void btn_RequestTest_Click(object sender, EventArgs e)
        {
            var request = ValidateRequestParameter();
            if (request != null)
            {
                var response = HttpBuilder.Handle(request);
                ConsoleLog(response);
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

        public void ConsoleLog(ResponseModel response)
        {
            rtxt_Console.Invoke(new Action<ResponseModel>(x =>
            {
                var log = string.Format("Status:{0}\r\n", x.StatusCode);
                rtxt_Console.AppendText(log);
            }), response);
        }
    }
}
