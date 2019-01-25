﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpTestTool.Models
{
    public class ResponseModel
    {
        public int StatusCode { get; set; }
        public string Response { get; set; }
        public Exception Exception { get; set; }
    }
}
