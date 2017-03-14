using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class InfrastructureFaultBuilderExtensions
    {
        /// <summary>
        /// System unavailable.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        public static Fault SystemUnavailable(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0001_SystemUnavailable.ToFault();
        }

        /// <summary>
        /// System timeout.
        ///
        /// REST Status: 408 Request Timeout
        /// </summary>
        public static Fault SystemTimeout(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0002_SystemTimeout.ToFault();
        }

        /// <summary>
        /// System internal error.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        public static Fault SystemInternalError(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0003_SystemInternalError.ToFault();
        }

        /// <summary>
        /// Unable to connect to the database.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        public static Fault DatabaseConnectionError(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0004_DatabaseConnectionError.ToFault();
        }

        /// <summary>
        /// System out of memory.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        public static Fault SystemOutOfMemory(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0005_SystemOutOfMemory.ToFault();
        }

        /// <summary>
        /// System out of disk space.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        public static Fault SystemOutOfDiskSpace(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0006_SystemOutOfDiskSpace.ToFault();
        }

        /// <summary>
        /// Maximum number of connections reached.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        public static Fault MaximumConnectionsReached(this IInfrastructureFaultBuilder builder)
        {
            return ErrorCode.INF_S00_0007_MaximumConnectionsReached.ToFault();
        }
    }
}