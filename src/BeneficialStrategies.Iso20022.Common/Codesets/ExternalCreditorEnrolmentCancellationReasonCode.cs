// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EvdPM_DCEemsS_0xy2XRug")]
[Description(
    @"Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCreditorEnrolmentCancellationReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorEnrolmentCancellationReasonCode>))]
#endif
public enum ExternalCreditorEnrolmentCancellationReasonCode
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuuxQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uu37MPRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uu37M_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uu37NvRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,

    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uu37OfRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
}
