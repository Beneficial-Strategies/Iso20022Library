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
[IsoId("_EvdPMvDCEemsS_0xy2XRug")]
[Description(
    @"Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCreditorEnrolmentCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorEnrolmentCancellationReason1Code>))]
#endif
public enum ExternalCreditorEnrolmentCancellationReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuuxRfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalCreditorEnrolmentCancellationReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uu37MvRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalCreditorEnrolmentCancellationReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uu37NfRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalCreditorEnrolmentCancellationReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uu37OPRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalCreditorEnrolmentCancellationReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uu37O_RYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalCreditorEnrolmentCancellationReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
}
