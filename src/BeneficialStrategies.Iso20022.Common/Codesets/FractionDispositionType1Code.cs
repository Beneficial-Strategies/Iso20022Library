// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arP_xNp-Ed-ak6NoX_4Aeg_-1827765528")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType1Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arP_xdp-Ed-ak6NoX_4Aeg_-1827765518")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp = FractionDispositionTypeCode.BuyUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arP_xtp-Ed-ak6NoX_4Aeg_-1827765517")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction = FractionDispositionTypeCode.CashInLieuOfFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_arP_x9p-Ed-ak6NoX_4Aeg_-1827765498")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeCode.IssueFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round down to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDDN&quot;.
    /// </summary>
    [EnumMember(Value = "RDDN")]
    [IsoId("_arP_yNp-Ed-ak6NoX_4Aeg_-1827765497")]
    [Description(@"Round down to the nearest whole number.")]
    RoundDown = FractionDispositionTypeCode.RoundDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round up to the nearest whole number.
    /// Encoded/decoded by serializers as &quot;RDUP&quot;.
    /// </summary>
    [EnumMember(Value = "RDUP")]
    [IsoId("_arZwwNp-Ed-ak6NoX_4Aeg_-1827765467")]
    [Description(@"Round up to the nearest whole number.")]
    RoundUp = FractionDispositionTypeCode.RoundUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_arZwwdp-Ed-ak6NoX_4Aeg_-1827765466")]
    [Description(@"If the fraction is greater than or equal to 0.5 of the resulting security then round up, else round down.")]
    RoundToNearest = FractionDispositionTypeCode.RoundToNearest, // same ordinal as derivation source for type conversions
    
}
