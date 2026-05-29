// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of batch management activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p2Dm4RQgEfC_aaedwHHlmw")]
[Description(@"Type of batch management activity.")]
[DerivedFrom(typeof(BatchManagementTypeCode))]
public enum BatchManagementType3Code
{
    /// <summary>
    /// Acknowledgement response by the destination to the originator (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRP&quot;.
    /// </summary>
    [EnumMember(Value = "AKRP")]
    [IsoId("_p9sf8xQgEfC_aaedwHHlmw")]
    [Description(@"Acknowledgement response by the destination to the originator (used with a notification message exclusively).")]
    AcknowledgementResponse = BatchManagementTypeCode.AcknowledgementResponse,

    /// <summary>
    /// Acknowledgement requested by the originator to the destination (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AKRQ")]
    [IsoId("_p9sf8RQgEfC_aaedwHHlmw")]
    [Description(@"Acknowledgement requested by the originator to the destination (used with a notification message exclusively).")]
    AcknowledgementRequest = BatchManagementTypeCode.AcknowledgementRequest,

    /// <summary>
    /// End of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;ENDB&quot;.
    /// </summary>
    [EnumMember(Value = "ENDB")]
    [IsoId("_p9sf9RQgEfC_aaedwHHlmw")]
    [Description(@"End of a collection or batch by the originator (used with a request message exclusively).")]
    End = BatchManagementTypeCode.End,

    /// <summary>
    /// Contains a list of batch or collection identifications.
    /// Encoded/decoded by serializers as &quot;IDNT&quot;.
    /// </summary>
    [EnumMember(Value = "IDNT")]
    [IsoId("_p9sf9xQgEfC_aaedwHHlmw")]
    [Description(@"Contains a list of batch or collection identifications.")]
    IdentificationList = BatchManagementTypeCode.IdentificationList,

    /// <summary>
    /// A request to resend a batch or collection.
    /// Encoded/decoded by serializers as &quot;RERQ&quot;.
    /// </summary>
    [EnumMember(Value = "RERQ")]
    [IsoId("_p9sf_RQgEfC_aaedwHHlmw")]
    [Description(@"A request to resend a batch or collection.")]
    ResendRequest = BatchManagementTypeCode.ResendRequest,

    /// <summary>
    /// Initiation of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;STRT&quot;.
    /// </summary>
    [EnumMember(Value = "STRT")]
    [IsoId("_p9sf_xQgEfC_aaedwHHlmw")]
    [Description(@"Initiation of a collection or batch by the originator (used with a request message exclusively).")]
    Start = BatchManagementTypeCode.Start,
}
