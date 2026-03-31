// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gtemoeIwEeqbls7Gk4-ckA")]
[Description(
    @"Specifies the  creditor enrolment status reason code, as published in an external  creditor enrolment status reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCreditorEnrolmentStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorEnrolmentStatusReason1Code>))]
#endif
public enum ExternalCreditorEnrolmentStatusReason1Code
{
    /// <summary>
    /// Already existing creditor.
    /// Encoded/decoded by serializers as &quot;ACRD&quot;.
    /// </summary>
    [EnumMember(Value = "ACRD")]
    [IsoId("_uvUnJfRYEeuLhpyIdtJzwg")]
    [Description(@"Already existing creditor.")]
    AlreadyExistingCreditor = ExternalCreditorEnrolmentStatusReasonCode.AlreadyExistingCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvUnKPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalCreditorEnrolmentStatusReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid file format.
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uvUnK_RYEeuLhpyIdtJzwg")]
    [Description(@"Invalid file format.")]
    InvalidFileFormat = ExternalCreditorEnrolmentStatusReasonCode.InvalidFileFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uveYIvRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalCreditorEnrolmentStatusReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uveYJfRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalCreditorEnrolmentStatusReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid character set.
    /// Encoded/decoded by serializers as &quot;RR10&quot;.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uvoJIvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid character set.")]
    InvalidCharacterSet = ExternalCreditorEnrolmentStatusReasonCode.InvalidCharacterSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uvoJJfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalCreditorEnrolmentStatusReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
}
