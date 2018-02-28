using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FattureInCloudNet
{
    public class Response
    {
        public int? ErrorCode { get; set; }
        public string Error { get; set; }
        public bool? Success { get; set; }
    }
}
