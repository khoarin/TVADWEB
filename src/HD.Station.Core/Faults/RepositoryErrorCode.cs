using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station
{
    public enum RepositoryErrorCode
    {
        /// <summary>
        /// ChangeNotAllowed.
        /// </summary>
        [Description("ChangeNotAllowed.")]
        [ErrorCode("SVC_S04_0001")]
        SVC_S04_0001,

        /// <summary>
        /// ExcessiveData.
        /// </summary>
        [Description("ExcessiveData.")]
        [ErrorCode("SVC_S04_0002")]
        SVC_S04_0002,

        /// <summary>
        /// FormatPropertiesExtraction.
        /// </summary>
        [Description("FormatPropertiesExtraction.")]
        [ErrorCode("SVC_S04_0003")]
        SVC_S04_0003,

        /// <summary>
        /// IncompleteEssence.
        /// </summary>
        [Description("IncompleteEssence.")]
        [ErrorCode("SVC_S04_0004")]
        SVC_S04_0004,

        /// <summary>
        /// PropertyActionNotAllowed.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S04_0005")]
        SVC_S04_0005,

        /// <summary>
        /// PropertyNotDefined.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S04_0006")]
        SVC_S04_0006,

        /// <summary>
        /// PropertyPathNotFound.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S04_0007")]
        SVC_S04_0007,

        /// <summary>
        /// PropertyValueNotSupported.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S04_0008")]
        SVC_S04_0008,

        /// <summary>
        /// RCRParameterViolation.
        /// </summary>
        [Description]
        [ErrorCode("SVC_S04_0009")]
        SVC_S04_0009,

        /// <summary>
        /// DuplicateContent.
        /// </summary>
        [Description("DuplicateContent.")]
        [ErrorCode("DAT_S04_0001")]
        DAT_S04_0001,

        /// <summary>
        /// DuplicateEssence.
        /// </summary>
        [Description("DuplicateEssence.")]
        [ErrorCode("DAT_S04_0002")]
        DAT_S04_0002,

        /// <summary>
        /// EssenceNotFound.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S04_0003")]
        DAT_S04_0003,

        /// <summary>
        /// EssenceSizeExceeded.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S04_0004")]
        DAT_S04_0004,

        /// <summary>
        /// ExternalReferenceViolation.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S04_0005")]
        DAT_S04_0005,

        /// <summary>
        /// InternalReferenceViolation.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S04_0006")]
        DAT_S04_0006,

        /// <summary>
        /// InvalidBMContentType.
        /// </summary>
        [Description]
        [ErrorCode("DAT_S04_0007")]
        DAT_S04_0007,

        /// <summary>
        /// InvalidEssence.
        /// </summary>
        [Description("InvalidEssence.")]
        [ErrorCode("DAT_S04_0008")]
        DAT_S04_0008,

        /// <summary>
        /// InvalidEssenceStructure.
        /// </summary>
        [Description("InvalidEssenceStructure.")]
        [ErrorCode("DAT_S04_0009")]
        DAT_S04_0009,

        /// <summary>
        /// InvalidExpirationDate.
        /// </summary>
        [Description("InvalidExpirationDate.")]
        [ErrorCode("DAT_S04_0010")]
        DAT_S04_0010,

        /// <summary>
        ///InvalidFormat.
        /// </summary>
        [Description("InvalidFormat.")]
        [ErrorCode("DAT_S04_0011")]
        DAT_S04_0011,

        /// <summary>
        ///InvalidQueryInputDefinition.
        /// </summary>
        [Description("InvalidQueryInputDefinition.")]
        [ErrorCode("DAT_S04_0012")]
        DAT_S04_0012,

        /// <summary>
        ///InvalidRegisteredLocation.
        /// </summary>
        [Description("InvalidRegisteredLocation.")]
        [ErrorCode("DAT_S04_0013")]
        DAT_S04_0013,

        /// <summary>
        ///MaxOperationDurationExceeded.
        /// </summary>
        [Description("MaxOperationDurationExceeded.")]
        [ErrorCode(" INF_S04_0001")]
        INF_S04_0001,
    }
}