// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S1ANk_DCEemsS_0xy2XRug")]
[Description(
    @"Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCreditorEnrolmentAmendmentReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorEnrolmentAmendmentReasonCode>))]
#endif
public enum ExternalCreditorEnrolmentAmendmentReasonCode
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuIUVvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uuIUWfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uuSFUPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_E5wqofDWEemsS_0xy2XRug")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,

    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_Ci0BYPDWEemsS_0xy2XRug")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
}
