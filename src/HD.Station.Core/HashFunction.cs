using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum HashFunction
    {
        CRC32 = 0,
        CRC64 = 1,
        MD5 = 2,
        SHA1 = 3,
        SHA256 = 4,
        SHA384 = 5,
        SHA512 = 6
    }
}