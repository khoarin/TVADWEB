using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum TransferErrorCode
    {
        /// <summary>
        /// Invalid URI protocol specified for Transport operations.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S01_0001")]
        DAT_S01_0001,

        /// <summary>
        /// Invalid OutpurDirectory or Target URI path.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S01_0002")]
        DAT_S01_0002,

        /// <summary>
        /// Incorrect Hash. File received does not have same hash as specified in the file hash value property.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S01_0003")]
        DAT_S01_0003,

        /// <summary>
        /// Unsupported protocol.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0001")]
        SVC_S01_0001,

        /// <summary>
        /// Unsupported hash type.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0002")]
        SVC_S01_0002,

        /// <summary>
        /// Encryption not supported.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0003")]
        SVC_S01_0003,

        /// <summary>
        /// Authentication not supported.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0004")]
        SVC_S01_0004,

        /// <summary>
        /// Integrity check not supported.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0005")]
        SVC_S01_0005,

        /// <summary>
        /// File too large.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0006")]
        SVC_S01_0006,

        /// <summary>
        /// Times not possible.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0007")]
        SVC_S01_0007,

        /// <summary>
        /// Incorrect file size.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0008")]
        SVC_S01_0008,

        /// <summary>
        /// Rejected by operator.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0009")]
        SVC_S01_0009,

        /// <summary>
        ///Transfer process ended unexpectedly.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S01_0010")]
        SVC_S01_0010,

        /// <summary>
        ///Network link with insufficient bandwidth.
        /// </summary>
        [Description]
        [ErrorCode("INF_S01_0001")]
        INF_S01_0001,

        /// <summary>
        ///Link timed out.
        /// </summary>
        [Description]
        [ErrorCode("INF_S01_0002")]
        INF_S01_0002,
    }
}