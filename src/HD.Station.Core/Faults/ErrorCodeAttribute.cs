using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Faults
{
    public class ErrorCodeAttribute : Attribute
    {
        public string Code { get; set; }

        public ErrorCodeAttribute()
        {
        }

        public ErrorCodeAttribute(string code)
        {
            this.Code = code;
        }

        public ErrorType Type { get; set; }

        public int ServiceNumber { get; set; }

        public int ErrorNumber { get; set; }

        public int ToEventId()
        {
            return (int)Type * (10 ^ 6) + ServiceNumber * (10 ^ 4) + ErrorNumber;
        }
    }
}