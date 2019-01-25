using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpTestTool.Models
{
    public class RequestModel
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public int TimeOut { get; set; }
        public bool AutoRedirect { get; set; }
        public bool KeepAlive { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Datas { get; set; }
    }
}
