using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class SecurityFaultBuilderExtensions
    {
        /// <summary>
        /// Invalid credential. REST Status: 403 Forbidden
        /// </summary>
        public static Fault CredentialInvalid(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0001_CredentialInvalid.ToFault();
        }

        /// <summary>
        /// Credential required. REST Status: 401 Unauthorized
        /// </summary>
        public static Fault CredentialRequired(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0002_CredentialRequired.ToFault();
        }

        /// <summary>
        /// Insufficient permission. REST Status: 403 Forbidden
        /// </summary>
        public static Fault PermissionInsufficient(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0003_PermissionInsufficient.ToFault();
        }

        /// <summary>
        /// Invalid token. REST Status: 403 Forbidden
        /// </summary>
        public static Fault TokenInvalid(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0004_TokenInvalid.ToFault();
        }

        /// <summary>
        /// Missing token. REST Status: 400 Bad Request
        /// </summary>
        public static Fault TokenMissing(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0005_TokenMissing.ToFault();
        }

        /// <summary>
        /// Resource locked. REST Status: 409 Conflict
        /// </summary>
        public static Fault ResourceLocked(this ISecurityFaultBuilder builder)
        {
            return ErrorCode.SEC_S00_0006_ResourceLocked.ToFault();
        }
    }
}