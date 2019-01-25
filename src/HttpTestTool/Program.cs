using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpTestTool
{
    static class Program
    {
        static Program()
        {
            int maxWorkerThreads, maxIoThreads;
            ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxIoThreads);
            ThreadPool.SetMinThreads(maxWorkerThreads, maxIoThreads);
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
