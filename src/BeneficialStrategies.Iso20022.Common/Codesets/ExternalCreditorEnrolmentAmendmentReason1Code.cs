// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S1ANkvDCEemsS_0xy2XRug")]
[Description(
    @"Specifies the creditor enrolment amendment reason code, as published in an external creditor enrolment amendment reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCreditorEnrolmentAmendmentReasonCode))]
public enum ExternalCreditorEnrolmentAmendmentReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuIUWPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalCreditorEnrolmentAmendmentReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uuIUW_RYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalCreditorEnrolmentAmendmentReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uuSFUvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalCreditorEnrolmentAmendmentReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uuSFVfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalCreditorEnrolmentAmendmentReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uuSFWPRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalCreditorEnrolmentAmendmentReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
}
