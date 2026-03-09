// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UZBfoeHEEd-1Ktb5rVaajw")]
[Description(@"Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.")]
[DerivedFrom(typeof(FractionDispositionTypeCode))]
public enum FractionDispositionType6Code
{
    /// <summary>
    /// Buy securities up to next whole number.
    /// Encoded/decoded by serializers as &quot;BUYU&quot;.
    /// </summary>
    [EnumMember(Value = "BUYU")]
    [IsoId("_q4hsVWtdEeCY4-KZ9JEyUQ_1821179655")]
    [Description(@"Buy securities up to next whole number.")]
    BuyUp = FractionDispositionTypeCode.BuyUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fractional part of cash. Take cash in lieu of fractions.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_q4hsVmtdEeCY4-KZ9JEyUQ_-844509347")]
    [Description(@"Fractional part of cash. Take cash in lieu of fractions.")]
    CashInLieuOfFraction = FractionDispositionTypeCode.CashInLieuOfFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Take distribution of fractions in the form of securities.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_q4rdUGtdEeCY4-KZ9JEyUQ_1872116818")]
    [Description(@"Take distribution of fractions in the form of securities.")]
    IssueFraction = FractionDispositionTypeCode.IssueFraction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Let fractions expire worthless.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_q4rdUWtdEeCY4-KZ9JEyUQ_875044465")]
    [Description(@"Let fractions expire worthless.")]
    Expire = FractionDispositionTypeCode.Expire, // same ordinal as derivation source for type conversions
    
}
