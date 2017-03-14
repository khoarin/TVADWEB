using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    using Faults;

    public enum CaptureErrorCode
    {
        ///<summary>
        ///Invalid target media format.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S03_0001")]
        SVC_S03_0001,

        ///<summary>
        ///Inconsistent time constraints.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S03_0002")]
        SVC_S03_0002,

        ///<summary>
        ///Invalid source ID.
        ///</summary>
        [Description]
        [ErrorCode("DAT_S03_0001")]
        DAT_S03_0001,
    }
}