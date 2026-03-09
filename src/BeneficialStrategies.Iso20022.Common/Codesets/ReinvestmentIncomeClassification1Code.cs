// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cash proceeds that the holder is eligible to reinvest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qxAYTL3EeKU9IrkkToqcw_904879687")]
[Description(@"Specifies the type of cash proceeds that the holder is eligible to reinvest.")]
[DerivedFrom(typeof(ReinvestmentIncomeClassificationCode))]
public enum ReinvestmentIncomeClassification1Code
{
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_1qxAYjL3EeKU9IrkkToqcw_-926958499")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend.")]
    CashDividend = ReinvestmentIncomeClassificationCode.CashDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend on increased shares.
    /// Encoded/decoded by serializers as &quot;CDIS&quot;.
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("_1qxAYzL3EeKU9IrkkToqcw_-1040797565")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend on increased shares.")]
    CashDividendOnIncreasedShares = ReinvestmentIncomeClassificationCode.CashDividendOnIncreasedShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the unfavourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDUN&quot;.
    /// </summary>
    [EnumMember(Value = "CDUN")]
    [IsoId("_1qxAZDL3EeKU9IrkkToqcw_430852457")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend at the unfavourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.")]
    CashDividendTaxUnfavorable = ReinvestmentIncomeClassificationCode.CashDividendTaxUnfavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the favourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDFV&quot;.
    /// </summary>
    [EnumMember(Value = "CDFV")]
    [IsoId("_1qxAZTL3EeKU9IrkkToqcw_-84465823")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend at the favourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.")]
    CashDividendTaxFavorable = ReinvestmentIncomeClassificationCode.CashDividendTaxFavorable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the exempt rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDEX&quot;.
    /// </summary>
    [EnumMember(Value = "CDEX")]
    [IsoId("_1qxAZjL3EeKU9IrkkToqcw_-198304889")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend at the exempt rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.")]
    CashDividendTaxExempt = ReinvestmentIncomeClassificationCode.CashDividendTaxExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as special cash dividend.
    /// Encoded/decoded by serializers as &quot;CDPS&quot;.
    /// </summary>
    [EnumMember(Value = "CDPS")]
    [IsoId("_1q6xYDL3EeKU9IrkkToqcw_369621446")]
    [Description(@"Cash proceeds being reinvested is classified as special cash dividend.")]
    CashDividendSpecial = ReinvestmentIncomeClassificationCode.CashDividendSpecial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as interest.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_1q6xYTL3EeKU9IrkkToqcw_358522669")]
    [Description(@"Cash proceeds being reinvested is classified as interest.")]
    Interest = ReinvestmentIncomeClassificationCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as principal.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_1q6xYjL3EeKU9IrkkToqcw_244683603")]
    [Description(@"Cash proceeds being reinvested is classified as principal.")]
    Principal = ReinvestmentIncomeClassificationCode.Principal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_1q6xYzL3EeKU9IrkkToqcw_-1640335412")]
    [Description(@"Cash proceeds being reinvested is classified as capital gains.")]
    CapitalGains = ReinvestmentIncomeClassificationCode.CapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as long term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_1q6xZDL3EeKU9IrkkToqcw_-1754174478")]
    [Description(@"Cash proceeds being reinvested is classified as long term capital gains.")]
    LongTermCapitalGains = ReinvestmentIncomeClassificationCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as short term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_1q6xZTL3EeKU9IrkkToqcw_-1315217905")]
    [Description(@"Cash proceeds being reinvested is classified as short term capital gains.")]
    ShortTermCapitalGains = ReinvestmentIncomeClassificationCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash proceeds being reinvested is classified as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_1q6xZjL3EeKU9IrkkToqcw_-237197567")]
    [Description(@"Cash proceeds being reinvested is classified as return of capital.")]
    ReturnOfCapital = ReinvestmentIncomeClassificationCode.ReturnOfCapital, // same ordinal as derivation source for type conversions
    
}
