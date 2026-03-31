// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the creditor enrolment status reason code, as published in an external creditor enrolment status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tareMeazEeqynejxNiO9NQ")]
[Description(
    @"Specifies the creditor enrolment status reason code, as published in an external creditor enrolment status reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCreditorEnrolmentStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorEnrolmentStatusReasonCode>))]
#endif
public enum ExternalCreditorEnrolmentStatusReasonCode
{
    /// <summary>
    /// Already existing creditor.
    /// Encoded/decoded by serializers as &quot;ACRD&quot;.
    /// </summary>
    [EnumMember(Value = "ACRD")]
    [IsoId("_uvUnI_RYEeuLhpyIdtJzwg")]
    [Description(@"Already existing creditor.")]
    AlreadyExistingCreditor,

    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvUnJvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,

    /// <summary>
    /// Invalid file format.
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uvUnKfRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid file format.")]
    InvalidFileFormat,

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uveYIPRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uveYI_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,

    /// <summary>
    /// Invalid character set.
    /// Encoded/decoded by serializers as &quot;RR10&quot;.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uvoJIPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid character set.")]
    InvalidCharacterSet,

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uvoJI_RYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,
}
