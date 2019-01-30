using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpTestTool.Models
{
    public class CounterModel
    {
        /// <summary>
        /// 线程Id
        /// </summary>
        public int ThreadId { get; set; }
        /// <summary>
        /// Http响应
        /// </summary>
        public ResponseModel Response { get; set; }
        /// <summary>
        /// 耗时秒数
        /// </summary>
        public long MilliSeconds { get; set; }
    }
}
