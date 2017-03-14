using HD.Station.Faults;
using HD.Station.Faults.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    /// <summary>
    /// Details of a fault. This type can be extended by each service to provide additional error codes.
    /// </summary>
    public partial class Fault : IEquatable<Fault>, IEqualityComparer<Fault>
    {
        /// <summary>
        /// The error code specified in <see cref="ErrorCode"/>
        /// </summary>
        /// <remarks>
        /// In the case of service-specific errors, "EXT_S00_0000" shall be set,
        /// and the specific error code shall be set in the child class "ExtendedErrorCode" field.
        /// </remarks>
        public ErrorCode Code { get; set; }

        /// <summary>
        /// An optional description of the error.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This optional field can provide a detailed description of the error.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// The relevant HttpStatusCode if available
        /// </summary>
        public int? HttpStatusCode { get; set; }

        #region IEquatable<T>

        public bool Equals(Fault other)
        {
            return this.Code == other?.Code;
        }

        #endregion IEquatable<T>

        #region IEqualityComparer<T>

        public bool Equals(Fault x, Fault y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Fault obj)
        {
            throw new NotImplementedException();
        }

        #endregion IEqualityComparer<T>

        /// <summary>
        /// Data errors (validation, missing, duplication)
        /// </summary>
        public static IDataFaultBuilder Data()
        {
            return new DataFaultBuilder();
        }

        /// <summary>
        /// Infrastructure errors (system, storage, network, memory, processor)
        /// </summary>
        public static IInfrastructureFaultBuilder Infrastructure()
        {
            return new InfrastructureFaultBuilder();
        }

        /// <summary>
        /// Operation errors (existence, support, lock, connection, failure)
        /// </summary>
        public static IOperationFaultBuilder Operation()
        {
            return new OperationFaultBuilder();
        }

        /// <summary>
        /// Security errors(authentication, authorization)
        /// </summary>
        public static ISecurityFaultBuilder Security()
        {
            return new SecurityFaultBuilder();
        }
    }
}