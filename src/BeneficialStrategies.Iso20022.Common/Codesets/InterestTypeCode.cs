// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__215c9ojEeC60axPepSq7g_-1926390567")]
[Description(@"Indicates if the deal price is excluding or including the accrued interest.")]
[Derivations(typeof(InterestType2Code), typeof(InterestType3Code))]
public enum InterestTypeCode
{
    /// <summary>
    /// Indicates deal price including accrued interest.
    /// Encoded/decoded by serializers as &quot;CINT&quot;.
    /// </summary>
    [EnumMember(Value = "CINT")]
    [IsoId("__215dNojEeC60axPepSq7g_-1809717898")]
    [Description(@"Indicates deal price including accrued interest.")]
    CumInterest,

    /// <summary>
    /// Indicates deal price excluding accrued interest.
    /// Encoded/decoded by serializers as &quot;XINT&quot;.
    /// </summary>
    [EnumMember(Value = "XINT")]
    [IsoId("__215ddojEeC60axPepSq7g_1908799161")]
    [Description(@"Indicates deal price excluding accrued interest.")]
    ExInterest,

    /// <summary>
    /// Indicates that the type of interest is a zero coupon.
    /// Encoded/decoded by serializers as &quot;ZCPN&quot;.
    /// </summary>
    [EnumMember(Value = "ZCPN")]
    [IsoId("_ha_UtWliEeGaMcKyqKNRfQ_405889650")]
    [Description(@"Indicates that the type of interest is a zero coupon.")]
    ZeroCoupon,

    /// <summary>
    /// Indicates that the type of interest is discounted.
    /// Encoded/decoded by serializers as &quot;DSCO&quot;.
    /// </summary>
    [EnumMember(Value = "DSCO")]
    [IsoId("_ha_UumliEeGaMcKyqKNRfQ_83685420")]
    [Description(@"Indicates that the type of interest is discounted.")]
    Discounted,

    /// <summary>
    /// Indicates that the type of interest is index.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ha_UuWliEeGaMcKyqKNRfQ_-1767325736")]
    [Description(@"Indicates that the type of interest is index.")]
    Index,

    /// <summary>
    /// Indicates that the type of interest is a dual basis.
    /// Encoded/decoded by serializers as &quot;DUAL&quot;.
    /// </summary>
    [EnumMember(Value = "DUAL")]
    [IsoId("_ha_UuGliEeGaMcKyqKNRfQ_-1760597089")]
    [Description(@"Indicates that the type of interest is a dual basis.")]
    DualBasis,

    /// <summary>
    /// Indicates that the type of interest is a floating rate note.
    /// Encoded/decoded by serializers as &quot;FLRN&quot;.
    /// </summary>
    [EnumMember(Value = "FLRN")]
    [IsoId("_ha_Ut2liEeGaMcKyqKNRfQ_-624589778")]
    [Description(@"Indicates that the type of interest is a floating rate note.")]
    FloatingRateNote,

    /// <summary>
    /// Indicates that the type of interest is fixed.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_ha_UtmliEeGaMcKyqKNRfQ_-590551397")]
    [Description(@"Indicates that the type of interest is fixed.")]
    Fixed,
}
