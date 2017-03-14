using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Faults
{
    public class HttpStatusCodeAttribute : Attribute
    {
        public int Code { get; set; }

        public HttpStatusCodeAttribute(int code)
        {
            this.Code = code;
        }
    }
}