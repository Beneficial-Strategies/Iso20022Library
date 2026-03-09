// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arZwx9p-Ed-ak6NoX_4Aeg_1382196643")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType3Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_arjhwNp-Ed-ak6NoX_4Aeg_1382196652")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp = FractionDispositionTypeCode.BuyUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_arjhwdp-Ed-ak6NoX_4Aeg_1382196668")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction = FractionDispositionTypeCode.CashInLieuOfFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_arjhwtp-Ed-ak6NoX_4Aeg_1382196669")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeCode.IssueFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_arjhw9p-Ed-ak6NoX_4Aeg_1758992666")]
    [Description(@"Let fractions expire worthless.")]
    Expire = FractionDispositionTypeCode.Expire, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Characteristics of the disposition of fractions are unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_arjhxNp-Ed-ak6NoX_4Aeg_299584857")]
    [Description(@"Characteristics of the disposition of fractions are unknown.")]
    Unknown = FractionDispositionTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}
