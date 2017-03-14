using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum TransformErrorCode
    {
        ///<summary>
        ///Invalid target media format.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S02_0001")]
        SVC_S02_0001,
    }
}