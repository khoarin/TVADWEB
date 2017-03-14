using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class DataFaultBuilderExtensions
    {
        /// <summary>
        /// Invalid request, XML format.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0001</c></remarks>
        public static Fault InvalidRequest(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0001_InvalidRequest.ToFault();
        }

        /// <summary>
        /// Invalid input media format.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0002</c></remarks>
        public static Fault InvalidInputFormat(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0002_InvalidInputFormat.ToFault();
        }

        /// <summary>
        /// Invalid jobID - the supplied jobID does not exist.
        ///
        /// REST Status: 404 Not Found
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0003</c></remarks>
        public static Fault InvalidJobId(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0003_InvalidJobId.ToFault();
        }

        /// <summary>
        /// Missing required service metadata in request.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0004</c></remarks>
        public static Fault SerivceMetadataMissing(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0004_SerivceMetadataMissing.ToFault();
        }

        /// <summary>
        /// Duplicate jobID detected for new job.
        /// REST Status: 409 Conflict
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0005</c></remarks>
        public static Fault DuplicateJobId(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0005_DuplicateJobId.ToFault();
        }

        /// <summary>
        /// Invalid request parameters.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0006</c></remarks>
        public static Fault ParametersInvalid(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0006_ParametersInvalid.ToFault();
        }

        /// <summary>
        /// Job command not valid.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0007</c></remarks>
        public static Fault InvalidJobCommand(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0007_InvalidJobCommand.ToFault();
        }

        /// <summary>
        /// Queue command not valid.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0008</c></remarks>
        public static Fault InvalidQueueCommand(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0008_InvalidQueueCommand.ToFault();
        }

        /// <summary>
        /// Invalid priority.
        ///
        /// REST Status: 403 Forbidden
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0009</c></remarks>
        public static Fault InvalidPriority(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0009_InvalidPriority.ToFault();
        }

        /// <summary>
        /// Input media not found. Invalid resource URI specified. REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0010</c></remarks>
        public static Fault InvalidResourceUri(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0010_InvalidResourceUri.ToFault();
        }

        /// <summary>
        /// Duplicate resource.
        ///
        /// REST Status: 409 Conflict
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0011</c></remarks>
        public static Fault DuplicateResource(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0011_DuplicateResource.ToFault();
        }

        /// <summary>
        /// Invalid resource.
        /// REST Status: 404 Not Found
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0012</c></remarks>
        public static Fault InvalidResource(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0012_InvalidResource.ToFault();
        }

        /// <summary>
        /// Invalid identifier.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0013</c></remarks>
        public static Fault InvalidIdentifier(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0013_InvalidIdentifier.ToFault();
        }

        /// <summary>
        /// Insufficient data.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0014</c></remarks>
        public static Fault InsufficientData(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0014_InsufficientData.ToFault();
        }

        /// <summary>
        /// Source content ID reference not found.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0015</c></remarks>
        public static Fault SourceContentReferenceIdNotFound(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0015_SourceContentReferenceIdNotFound.ToFault();
        }

        /// <summary>
        /// Specified range is out of bounds.
        ///
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0016</c></remarks>
        public static Fault RangeOutOfBounds(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0016_RangeOutOfBounds.ToFault();
        }

        /// <summary>
        /// Invalid input media format.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0017</c></remarks>
        public static Fault InvalidMediaFormat(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0017_InvalidMediaFormat.ToFault();
        }

        /// <summary>
        /// Rounded boundaries of content part.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0018</c></remarks>
        public static Fault DAT_S00_0018(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0018.ToFault();
        }

        /// <summary>
        /// Incompatible media formats.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0019</c></remarks>
        public static Fault IncompatibleMediaFormat(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0019_IncompatibleMediaFormat.ToFault();
        }

        /// <summary>
        /// Ill formed composition list.
        /// REST Status: 400 Bad Request
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0020</c></remarks>
        public static Fault IllFormedCompositionList(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0020_IllFormedCompositionList.ToFault();
        }

        /// <summary>
        /// Unsupported media type requested in Accept header.
        /// REST Status: 415 Unsupported Media Type
        /// </summary>
        /// <remarks>Error code: <c>DAT_S00_0021</c></remarks>
        public static Fault UnsupportedMediaTypeRequested(this IDataFaultBuilder builder)
        {
            return ErrorCode.DAT_S00_0021_UnsupportedMediaTypeRequested.ToFault();
        }
    }
}