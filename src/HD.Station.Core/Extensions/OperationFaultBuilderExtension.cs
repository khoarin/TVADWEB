using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class OperationFaultBuilderExtension
    {
        /// <summary>
        /// Job command is not currently supported by the service URI specified.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault JobCommandNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0001_JobCommandNotSupported.ToFault();
        }

        /// <summary>
        /// Queue command is not currently supported by the service or the device.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault QueueCommandNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0002_QueueCommandNotSupported.ToFault();
        }

        /// <summary>
        /// Operation requested is not currently supported by the service or the device.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault OperationRequestNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0003_OperationRequestNotSupported.ToFault();
        }

        /// <summary>
        /// Service unable to find/lookup device endpoint.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        public static Fault EndpointNotFound(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0004_EndpointNotFound.ToFault();
        }

        /// <summary>
        /// Job command failed.
        /// </summary>
        public static Fault JobCommandFailed(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0005_JobCommandFailed.ToFault();
        }

        /// <summary>
        /// Queue command failed.
        /// </summary>
        public static Fault QueueCommandFailed(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0006_QueueCommandFailed.ToFault();
        }

        /// <summary>
        /// Service unable to connect to device endpoint.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        public static Fault EndpointUnreachable(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0007_EndpointUnreachable.ToFault();
        }

        /// <summary>
        /// Job queue is full, locked or stopped. No new jobs are being accepted.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        public static Fault JobQueueUnavailable(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0008_JobQueueUnavailable.ToFault();
        }

        /// <summary>
        /// Job ended with a failure.
        /// </summary>
        public static Fault JobEndedWithFailure(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0009_JobEndedWithFailure.ToFault();
        }

        /// <summary>
        /// Service received no response from device.
        ///
        /// REST Status: 504 Gateway Timeout.
        /// </summary>
        public static Fault EndpointNotResponse(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0010_EndpointNotResponse.ToFault();
        }

        /// <summary>
        /// Service received an exception from device. See description or exception detail.
        ///
        /// REST Status: 502 Bad Gateway.
        /// </summary>
        public static Fault EndpointExecptioned(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0011_EndpointExecptioned.ToFault();
        }

        /// <summary>
        /// Service received an unknown or an internal error from device.
        /// See description for error detail.
        ///
        /// REST Status: 502 Bad Gateway.
        /// </summary>
        public static Fault EndpointInternalError(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0012_EndpointInternalError.ToFault();
        }

        /// <summary>
        /// Unable to connect to client's notification service endpoint (replyTo)
        /// to send the asynchronous job result notification response.
        /// </summary>
        public static Fault ReplyToEndpointUnreachable(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0013_ReplyToEndpointUnreachable.ToFault();
        }

        /// <summary>
        /// Unable to connect to client's service endpoint (faultTo)
        /// to send the asynchronous job fault response.
        /// </summary>
        public static Fault FaultToEndpointUnreachable(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0014_FaultToEndpointUnreachable.ToFault();
        }

        /// <summary>
        /// Feature not supported.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault FeatureNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0015_FeatureNotSupported.ToFault();
        }

        /// <summary>
        /// Deadline passed.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault DeadlinePassed(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0016_DeadlinePassed.ToFault();
        }

        /// <summary>
        /// Time constraints in request cannot be met.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        public static Fault TimeConstraintNotMet(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0017_TimeConstraintNotMet.ToFault();
        }

        /// <summary>
        /// Internal or unknown error encountered. See description for error detail.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        public static Fault InternalError(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0018_InternalError.ToFault();
        }

        /// <summary>
        /// Version mismatch.
        ///
        /// REST Status: 412 Precondition Failed
        /// </summary>
        public static Fault VersionMismatch(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0019_VersionMismatch.ToFault();
        }

        /// <summary>
        /// License expired.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        public static Fault LicenseExprired(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0020_LicenseExprired.ToFault();
        }

        /// <summary>
        /// Service state conflict.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        public static Fault ServiceStateConflict(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0021_ServiceStateConflict.ToFault();
        }

        /// <summary>
        /// Operation not allowed.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        public static Fault OperationNotAllowed(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0022_OperationNotAllowed.ToFault();
        }

        /// <summary>
        /// Partial job failure. See inner faults for details.
        /// </summary>
        public static Fault PartialJobFailure(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0023_PartialJobFailure.ToFault();
        }

        /// <summary>
        /// Content Part processing not supported.
        /// </summary>
        public static Fault ContentPartProcessingNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0024_ContentPartProcessingNotSupported.ToFault();
        }

        /// <summary>
        /// Multiple Content Parts not supported.
        /// </summary>
        public static Fault ContentPartNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0025_ContentPartNotSupported.ToFault();
        }

        /// <summary>
        /// Content Part cannot be generated.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        public static Fault ContentPartCannotBeGenerated(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0026_ContentPartCannotBeGenerated.ToFault();
        }

        /// <summary>
        /// Composite content not supported.
        /// </summary>
        public static Fault CompositeContentNotSupported(this IOperationFaultBuilder builder)
        {
            return ErrorCode.SVC_S00_0027_CompositeContentNotSupported.ToFault();
        }
    }
}