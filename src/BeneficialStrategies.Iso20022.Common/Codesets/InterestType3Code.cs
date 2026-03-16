// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether interest rate is fixed, variable or other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha_Uu2liEeGaMcKyqKNRfQ_-331678715")]
[Description(@"Indicates whether interest rate is fixed, variable or other.")]
[DerivedFrom(typeof(InterestTypeCode))]
public enum InterestType3Code
{
    /// <summary>
    /// Indicates that the type of interest is a zero coupon.
    /// Encoded/decoded by serializers as &quot;ZCPN&quot;.
    /// </summary>
    [EnumMember(Value = "ZCPN")]
    [IsoId("_ha_UvGliEeGaMcKyqKNRfQ_2005580526")]
    [Description(@"Indicates that the type of interest is a zero coupon.")]
    ZeroCoupon = InterestTypeCode.ZeroCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the type of interest is fixed.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_ha_UvWliEeGaMcKyqKNRfQ_-583192410")]
    [Description(@"Indicates that the type of interest is fixed.")]
    Fixed = InterestTypeCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the type of interest is a floating rate note.
    /// Encoded/decoded by serializers as &quot;FLRN&quot;.
    /// </summary>
    [EnumMember(Value = "FLRN")]
    [IsoId("_ha_UvmliEeGaMcKyqKNRfQ_-1218224256")]
    [Description(@"Indicates that the type of interest is a floating rate note.")]
    FloatingRateNote = InterestTypeCode.FloatingRateNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the type of interest is a dual basis.
    /// Encoded/decoded by serializers as &quot;DUAL&quot;.
    /// </summary>
    [EnumMember(Value = "DUAL")]
    [IsoId("_ha_Uv2liEeGaMcKyqKNRfQ_1701818028")]
    [Description(@"Indicates that the type of interest is a dual basis.")]
    DualBasis = InterestTypeCode.DualBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the type of interest is index.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ha_UwGliEeGaMcKyqKNRfQ_1306353277")]
    [Description(@"Indicates that the type of interest is index.")]
    Index = InterestTypeCode.Index, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the type of interest is discounted.
    /// Encoded/decoded by serializers as &quot;DSCO&quot;.
    /// </summary>
    [EnumMember(Value = "DSCO")]
    [IsoId("_ha_UwWliEeGaMcKyqKNRfQ_-1863117043")]
    [Description(@"Indicates that the type of interest is discounted.")]
    Discounted = InterestTypeCode.Discounted, // same ordinal as derivation source for type conversions
}
