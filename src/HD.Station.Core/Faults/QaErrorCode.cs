using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum QaErrorCode
    {
        ///<summary>
        ///Report not available.
        ///</summary>
        [Description]
        [ErrorCode("DAT_S05_0001")]
        DAT_S05_0001,

        ///<summary>
        ///Template not available.
        ///</summary>
        [Description]
        [ErrorCode("DAT_S05_0002")]
        DAT_S05_0002,

        ///<summary>
        ///Encryption not supported.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0001")]
        SVC_S05_0001,

        ///<summary>
        ///Authentication not supported.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0002")]
        SVC_S05_0002,

        ///<summary>
        ///File too large.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0003")]
        SVC_S05_0003,

        ///<summary>
        ///Scope out of bounds.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0004")]
        SVC_S05_0004,

        ///<summary>
        ///Scope not supported.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0005")]
        SVC_S05_0005,

        ///<summary>
        ///Rejected by operator.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0006")]
        SVC_S05_0006,

        ///<summary>
        ///Quality analysis ended unexpectedly.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0007")]
        SVC_S05_0007,

        ///<summary>
        ///Unsupported template.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0008")]
        SVC_S05_0008,

        ///<summary>
        ///Unsupported item or items.
        ///</summary>
        [Description]
        [ErrorCode("SVC_S05_0009")]
        SVC_S05_0009,
    }
}