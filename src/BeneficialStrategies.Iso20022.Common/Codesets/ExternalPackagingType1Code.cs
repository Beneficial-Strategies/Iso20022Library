// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the packaging type as published in an external packaging type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRd1mAEcEeCQm6a_G2yO_w_337823132")]
[Description(
    @"Specifies the packaging type as published in an external packaging type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalPackagingTypeCode))]
public enum ExternalPackagingType1Code
{
    /// <summary>
    /// Packaging is high density polyethylene.
    /// Encoded/decoded by serializers as &quot;HDPE&quot;.
    /// </summary>
    [EnumMember(Value = "HDPE")]
    [IsoId("_uIlXS_RYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is high density polyethylene.")]
    HighDensityPolyethylene = ExternalPackagingTypeCode.HighDensityPolyethylene, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Packaging is low density polyethylene.
    /// Encoded/decoded by serializers as &quot;LDPE&quot;.
    /// </summary>
    [EnumMember(Value = "LDPE")]
    [IsoId("_uIlXTvRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is low density polyethylene.")]
    LowDensityPolyethylene = ExternalPackagingTypeCode.LowDensityPolyethylene, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Packaging is linear low density polyethylene.
    /// Encoded/decoded by serializers as &quot;LLDP&quot;.
    /// </summary>
    [EnumMember(Value = "LLDP")]
    [IsoId("_uIvIQvRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is linear low density polyethylene.")]
    LinearLowDensityPolyethylene = ExternalPackagingTypeCode.LinearLowDensityPolyethylene, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other packaging type not otherwise specified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIvIRfRYEeuLhpyIdtJzwg")]
    [Description(@"Other packaging type not otherwise specified.")]
    OtherPackagingType = ExternalPackagingTypeCode.OtherPackagingType, // same ordinal as derivation source for type conversions
}
