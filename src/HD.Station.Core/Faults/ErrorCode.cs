using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    using Faults;

    public enum ErrorCode
    {
        #region Infrastructure errors (system, storage, network, memory, processor)

        /// <summary>
        /// System unavailable.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        [Description("System unavailable.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 1)]
        [HttpStatusCode(503)]
        INF_S00_0001_SystemUnavailable,

        /// <summary>
        /// System timeout.
        ///
        /// REST Status: 408 Request Timeout
        /// </summary>
        [Description("System timeout.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 2)]
        [HttpStatusCode(408)]
        INF_S00_0002_SystemTimeout,

        /// <summary>
        /// System internal error.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        [Description("System internal error.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 3)]
        [HttpStatusCode(500)]
        INF_S00_0003_SystemInternalError,

        /// <summary>
        /// Unable to connect to the database.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        [Description("Unable to connect to the database.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 4)]
        [HttpStatusCode(500)]
        INF_S00_0004_DatabaseConnectionError,

        /// <summary>
        /// System out of memory.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        [Description("System out of memory.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 5)]
        [HttpStatusCode(500)]
        INF_S00_0005_SystemOutOfMemory,

        /// <summary>
        /// System out of disk space.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        [Description("System out of disk space.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 6)]
        [HttpStatusCode(500)]
        INF_S00_0006_SystemOutOfDiskSpace,

        /// <summary>
        /// Maximum number of connections reached.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        [Description("Maximum number of connections reached.")]
        [ErrorCode(Type = ErrorType.INF, ServiceNumber = 0, ErrorNumber = 7)]
        [HttpStatusCode(503)]
        INF_S00_0007_MaximumConnectionsReached,

        #endregion Infrastructure errors (system, storage, network, memory, processor)

        #region Operation errors (existence, support, lock, connection, failure)

        /// <summary>
        /// Job command is not currently supported by the service URI specified.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Job command is not currently supported by the service URI specified.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 1)]
        [HttpStatusCode(403)]
        SVC_S00_0001_JobCommandNotSupported,

        /// <summary>
        /// Queue command is not currently supported by the service or the device.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Queue command is not currently supported by the service or the device.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 2)]
        [HttpStatusCode(403)]
        SVC_S00_0002_QueueCommandNotSupported,

        /// <summary>
        /// Operation requested is not currently supported by the service or the device.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Operation requested is not currently supported by the service or the device.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 3)]
        [HttpStatusCode(403)]
        SVC_S00_0003_OperationRequestNotSupported,

        /// <summary>
        /// Service unable to find/lookup device endpoint.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        [Description("Service unable to find/lookup device endpoint.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 4)]
        [HttpStatusCode(502)]
        SVC_S00_0004_EndpointNotFound,

        /// <summary>
        /// Job command failed.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 5)]
        SVC_S00_0005_JobCommandFailed,

        /// <summary>
        /// Queue command failed.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 6)]
        SVC_S00_0006_QueueCommandFailed,

        /// <summary>
        /// Service unable to connect to device endpoint.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 7)]
        [HttpStatusCode(502)]
        SVC_S00_0007_EndpointUnreachable,

        /// <summary>
        /// Job queue is full, locked or stopped. No new jobs are being accepted.
        ///
        /// REST Status: 503 Service Unavailable
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 8)]
        [HttpStatusCode(503)]
        SVC_S00_0008_JobQueueUnavailable,

        /// <summary>
        /// Job ended with a failure.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 9)]
        SVC_S00_0009_JobEndedWithFailure,

        /// <summary>
        /// Service received no response from device.
        ///
        /// REST Status: 504 Gateway Timeout.
        /// </summary>
        [Description("Service received no response from device.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 10)]
        [HttpStatusCode(504)]
        SVC_S00_0010_EndpointNotResponse,

        /// <summary>
        /// Service received an exception from device. See description or exception detail.
        ///
        /// REST Status: 502 Bad Gateway.
        /// </summary>
        [Description("Service received an exception from device.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 11)]
        [HttpStatusCode(502)]
        SVC_S00_0011_EndpointExecptioned,

        /// <summary>
        /// Service received an unknown or an internal error from device.
        /// See description for error detail.
        ///
        /// REST Status: 502 Bad Gateway.
        /// </summary>
        [Description("Service received an unknown or an internal error from device.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 12)]
        [HttpStatusCode(502)]
        SVC_S00_0012_EndpointInternalError,

        /// <summary>
        /// Unable to connect to client's notification service endpoint (replyTo)
        /// to send the asynchronous job result notification response.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 13)]
        SVC_S00_0013_ReplyToEndpointUnreachable,

        /// <summary>
        /// Unable to connect to client's service endpoint (faultTo)
        /// to send the asynchronous job fault response.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 14)]
        SVC_S00_0014_FaultToEndpointUnreachable,

        /// <summary>
        /// Feature not supported.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Feature not supported.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 15)]
        [HttpStatusCode(403)]
        SVC_S00_0015_FeatureNotSupported,

        /// <summary>
        /// Deadline passed.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Deadline passed.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 16)]
        [HttpStatusCode(403)]
        SVC_S00_0016_DeadlinePassed,

        /// <summary>
        /// Time constraints in request cannot be met.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Time constraints in request cannot be met.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 17)]
        [HttpStatusCode(403)]
        SVC_S00_0017_TimeConstraintNotMet,

        /// <summary>
        /// Internal or unknown error encountered. See description for error detail.
        ///
        /// REST Status: 500 Internal Server Error
        /// </summary>
        [Description("Internal or unknown error encountered.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 18)]
        [HttpStatusCode(500)]
        SVC_S00_0018_InternalError,

        /// <summary>
        /// Version mismatch.
        ///
        /// REST Status: 412 Precondition Failed
        /// </summary>
        [Description("Version mismatch.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 19)]
        [HttpStatusCode(412)]
        SVC_S00_0019_VersionMismatch,

        /// <summary>
        /// License expired.
        ///
        /// REST Status: 502 Bad Gateway
        /// </summary>
        [Description("License expired.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 20)]
        [HttpStatusCode(502)]
        SVC_S00_0020_LicenseExprired,

        /// <summary>
        /// Service state conflict.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        [Description("Service state conflict.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 21)]
        [HttpStatusCode(409)]
        SVC_S00_0021_ServiceStateConflict,

        /// <summary>
        /// Operation not allowed.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        [Description("Operation not allowed.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 22)]
        [HttpStatusCode(409)]
        SVC_S00_0022_OperationNotAllowed,

        /// <summary>
        /// Partial job failure. See inner faults for details.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 23)]
        SVC_S00_0023_PartialJobFailure,

        /// <summary>
        /// Content Part processing not supported.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 24)]
        SVC_S00_0024_ContentPartProcessingNotSupported,

        /// <summary>
        /// Multiple Content Parts not supported.
        /// </summary>
        [Description("Multiple Content Parts not supported.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 25)]
        SVC_S00_0025_ContentPartNotSupported,

        /// <summary>
        /// Content Part cannot be generated.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Content Part cannot be generated.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 26)]
        [HttpStatusCode(400)]
        SVC_S00_0026_ContentPartCannotBeGenerated,

        /// <summary>
        /// Composite content not supported.
        /// </summary>
        [Description]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 27)]
        SVC_S00_0027_CompositeContentNotSupported,

        #endregion Operation errors (existence, support, lock, connection, failure)

        #region Data errors (validation, missing, duplication)

        /// <summary>
        /// Invalid request, XML format.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Invalid request, XML format.")]
        [ErrorCode(Type = ErrorType.DAT, ServiceNumber = 0, ErrorNumber = 1)]
        [HttpStatusCode(400)]
        DAT_S00_0001_InvalidRequest,

        /// <summary>
        /// Invalid input media format.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Invalid input media format.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 2)]
        [HttpStatusCode(403)]
        DAT_S00_0002_InvalidInputFormat,

        /// <summary>
        /// Invalid jobID - the supplied jobID does not exist.
        ///
        /// REST Status: 404 Not Found
        /// </summary>
        [Description("Invalid jobID - the supplied jobID does not exist.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 3)]
        [HttpStatusCode(404)]
        DAT_S00_0003_InvalidJobId,

        /// <summary>
        /// Missing required service metadata in request.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Missing required service metadata in request.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 4)]
        [HttpStatusCode(400)]
        DAT_S00_0004_SerivceMetadataMissing,

        /// <summary>
        /// Duplicate jobID detected for new job.
        /// REST Status: 409 Conflict
        /// </summary>
        [Description("Duplicate jobID detected for new job.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 5)]
        [HttpStatusCode(409)]
        DAT_S00_0005_DuplicateJobId,

        /// <summary>
        /// Invalid request parameters.
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Invalid request parameters.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 6)]
        [HttpStatusCode(400)]
        DAT_S00_0006_ParametersInvalid,

        /// <summary>
        /// Job command not valid.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Job command not valid.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 7)]
        [HttpStatusCode(403)]
        DAT_S00_0007_InvalidJobCommand,

        /// <summary>
        /// Queue command not valid.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Queue command not valid.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 8)]
        [HttpStatusCode(403)]
        DAT_S00_0008_InvalidQueueCommand,

        /// <summary>
        /// Invalid priority.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        [Description("Invalid priority.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 9)]
        [HttpStatusCode(403)]
        DAT_S00_0009_InvalidPriority,

        /// <summary>
        /// Input media not found. Invalid resource URI specified. REST Status: 400 Bad Request
        /// </summary>
        [Description("Input media not found. Invalid resource URI specified.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 10)]
        [HttpStatusCode(400)]
        DAT_S00_0010_InvalidResourceUri,

        /// <summary>
        /// Duplicate resource.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        [Description("Duplicate resource.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 11)]
        [HttpStatusCode(409)]
        DAT_S00_0011_DuplicateResource,

        /// <summary>
        /// Invalid resource.
        /// REST Status: 404 Not Found
        /// </summary>
        [Description("Invalid resource.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 12)]
        [HttpStatusCode(404)]
        DAT_S00_0012_InvalidResource,

        /// <summary>
        /// Invalid identifier.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Invalid identifier.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 13)]
        [HttpStatusCode(400)]
        DAT_S00_0013_InvalidIdentifier,

        /// <summary>
        /// Insufficient data.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Insufficient data.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 14)]
        [HttpStatusCode(400)]
        DAT_S00_0014_InsufficientData,

        /// <summary>
        /// Source content ID reference not found.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Source content ID reference not found.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 15)]
        [HttpStatusCode(400)]
        DAT_S00_0015_SourceContentReferenceIdNotFound,

        /// <summary>
        /// Specified range is out of bounds.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        [Description("Specified range is out of bounds.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 16)]
        [HttpStatusCode(400)]
        DAT_S00_0016_RangeOutOfBounds,

        /// <summary>
        /// Invalid input media format. REST Status: 400 Bad Request
        /// </summary>
        [Description("Invalid input media format.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 17)]
        [HttpStatusCode(400)]
        DAT_S00_0017_InvalidMediaFormat,

        /// <summary>
        /// Rounded boundaries of content part. REST Status: 400 Bad Request
        /// </summary>
        [Description("Rounded boundaries of content part.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 18)]
        [HttpStatusCode(400)]
        DAT_S00_0018,

        /// <summary>
        /// Incompatible media formats. REST Status: 400 Bad Request
        /// </summary>
        [Description("Incompatible media formats.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 19)]
        [HttpStatusCode(400)]
        DAT_S00_0019_IncompatibleMediaFormat,

        /// <summary>
        /// Ill formed composition list. REST Status: 400 Bad Request
        /// </summary>
        [Description("Ill formed composition list.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 20)]
        [HttpStatusCode(400)]
        DAT_S00_0020_IllFormedCompositionList,

        /// <summary>
        /// Unsupported media type requested in Accept header. REST Status: 415 Unsupported Media Type
        /// </summary>
        [Description("Unsupported media type requested in Accept header.")]
        [ErrorCode(Type = ErrorType.SVC, ServiceNumber = 0, ErrorNumber = 21)]
        [HttpStatusCode(415)]
        DAT_S00_0021_UnsupportedMediaTypeRequested,

        #endregion Data errors (validation, missing, duplication)

        #region Extended code. See extended error code for detail.

        /// <summary>
        ///Extended code. See extended error code for details.
        /// </summary>
        [Description]
        [ErrorCode("EXT_S00_0000")]
        EXT_S00_0000,

        #endregion Extended code. See extended error code for detail.

        #region SEC_S00_xxxx: Security errors (authentication, authorization)

        /// <summary>
        /// Invalid credential. REST Status: 403 Forbidden
        /// </summary>
        [Description("Invalid credential.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 1)]
        [HttpStatusCode(403)]
        SEC_S00_0001_CredentialInvalid,

        /// <summary>
        /// Credential required. REST Status: 401 Unauthorized
        /// </summary>
        [Description("Credential required.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 2)]
        [HttpStatusCode(401)]
        SEC_S00_0002_CredentialRequired,

        /// <summary>
        /// Insufficient permission. REST Status: 403 Forbidden
        /// </summary>
        [Description("Insufficient permission.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 3)]
        [HttpStatusCode(403)]
        SEC_S00_0003_PermissionInsufficient,

        /// <summary>
        /// Invalid token. REST Status: 403 Forbidden
        /// </summary>
        [Description("Invalid token.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 4)]
        [HttpStatusCode(403)]
        SEC_S00_0004_TokenInvalid,

        /// <summary>
        /// Missing token. REST Status: 400 Bad Request
        /// </summary>
        [Description("Missing token.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 5)]
        [HttpStatusCode(400)]
        SEC_S00_0005_TokenMissing,

        /// <summary>
        /// Resource locked. REST Status: 409 Conflict
        /// </summary>
        [Description("Resource locked.")]
        [ErrorCode(Type = ErrorType.SEC, ServiceNumber = 0, ErrorNumber = 6)]
        [HttpStatusCode(409)]
        SEC_S00_0006_ResourceLocked,

        #endregion SEC_S00_xxxx: Security errors (authentication, authorization)
    }
}