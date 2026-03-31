// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debtor activation status reason code, as published in an external debtor activation status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pe4x4-IwEeqbls7Gk4-ckA")]
[Description(
    @"Specifies the debtor activation status reason code, as published in an external debtor activation status reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalDebtorActivationStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalDebtorActivationStatusReason1Code>))]
#endif
public enum ExternalDebtorActivationStatusReason1Code
{
    /// <summary>
    /// Already existing creditor.
    /// Encoded/decoded by serializers as &quot;ACRD&quot;.
    /// </summary>
    [EnumMember(Value = "ACRD")]
    [IsoId("_uvoJKPRYEeuLhpyIdtJzwg")]
    [Description(@"Already existing creditor.")]
    AlreadyExistingCreditor = ExternalDebtorActivationStatusReasonCode.AlreadyExistingCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvoJK_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalDebtorActivationStatusReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid file format.
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uvxTEvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid file format.")]
    InvalidFileFormat = ExternalDebtorActivationStatusReasonCode.InvalidFileFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvxTFfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalDebtorActivationStatusReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvxTGPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalDebtorActivationStatusReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid character set.
    /// Encoded/decoded by serializers as &quot;RR10&quot;.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uv7EEvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid character set.")]
    InvalidCharacterSet = ExternalDebtorActivationStatusReasonCode.InvalidCharacterSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uv7EFfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalDebtorActivationStatusReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
}
