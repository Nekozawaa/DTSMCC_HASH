using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.ViewModels
{
    public class ResponseClient
    {
        public string message { set; get; }
        public int statusCode { set; get; }
        public ResponseLogin data { set; get; }
    }
}
