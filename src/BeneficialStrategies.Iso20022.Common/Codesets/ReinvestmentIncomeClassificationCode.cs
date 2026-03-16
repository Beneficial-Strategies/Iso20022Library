// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cash proceeds that the holder is eligible to reinvest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qUUcDL3EeKU9IrkkToqcw_-747430383")]
[Description(@"Specifies the type of cash proceeds that the holder is eligible to reinvest.")]
[Derivations(
    typeof(ReinvestmentIncomeClassification1Code),
    typeof(ReinvestmentIncomeClassification2Code)
)]
public enum ReinvestmentIncomeClassificationCode
{
    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_1qUUcTL3EeKU9IrkkToqcw_1254015071")]
    [Description(@"Cash proceeds being reinvested is classified as cash dividend.")]
    CashDividend,

    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend on increased shares.
    /// Encoded/decoded by serializers as &quot;CDIS&quot;.
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("_1qUUcjL3EeKU9IrkkToqcw_-1048800112")]
    [Description(
        @"Cash proceeds being reinvested is classified as cash dividend on increased shares."
    )]
    CashDividendOnIncreasedShares,

    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the unfavourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDUN&quot;.
    /// </summary>
    [EnumMember(Value = "CDUN")]
    [IsoId("_1qUUczL3EeKU9IrkkToqcw_134134675")]
    [Description(
        @"Cash proceeds being reinvested is classified as cash dividend at the unfavourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service."
    )]
    CashDividendTaxUnfavorable,

    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the favourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDFV&quot;.
    /// </summary>
    [EnumMember(Value = "CDFV")]
    [IsoId("_1qUUdDL3EeKU9IrkkToqcw_-728574568")]
    [Description(
        @"Cash proceeds being reinvested is classified as cash dividend at the favourable rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service."
    )]
    CashDividendTaxFavorable,

    /// <summary>
    /// Cash proceeds being reinvested is classified as cash dividend at the exempt rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service.
    /// Encoded/decoded by serializers as &quot;CDEX&quot;.
    /// </summary>
    [EnumMember(Value = "CDEX")]
    [IsoId("_1qUUdTL3EeKU9IrkkToqcw_-1296140013")]
    [Description(
        @"Cash proceeds being reinvested is classified as cash dividend at the exempt rate elected through the DTC (the Depository Trust Company) Foreign Tax Payment service."
    )]
    CashDividendTaxExempt,

    /// <summary>
    /// Cash proceeds being reinvested is classified as special cash dividend.
    /// Encoded/decoded by serializers as &quot;CDPS&quot;.
    /// </summary>
    [EnumMember(Value = "CDPS")]
    [IsoId("_1qUUdjL3EeKU9IrkkToqcw_1380521662")]
    [Description(@"Cash proceeds being reinvested is classified as special cash dividend.")]
    CashDividendSpecial,

    /// <summary>
    /// Cash proceeds being reinvested is classified as interest.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_1qeFcDL3EeKU9IrkkToqcw_-1823168736")]
    [Description(@"Cash proceeds being reinvested is classified as interest.")]
    Interest,

    /// <summary>
    /// Cash proceeds being reinvested is classified as principal.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_1qeFcTL3EeKU9IrkkToqcw_1292772606")]
    [Description(@"Cash proceeds being reinvested is classified as principal.")]
    Principal,

    /// <summary>
    /// Cash proceeds being reinvested is classified as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_1qeFcjL3EeKU9IrkkToqcw_323804146")]
    [Description(@"Cash proceeds being reinvested is classified as capital gains.")]
    CapitalGains,

    /// <summary>
    /// Cash proceeds being reinvested is classified as long term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_1qeFczL3EeKU9IrkkToqcw_2093519516")]
    [Description(@"Cash proceeds being reinvested is classified as long term capital gains.")]
    LongTermCapitalGains,

    /// <summary>
    /// Cash proceeds being reinvested is classified as short term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_1qeFdDL3EeKU9IrkkToqcw_-1773914264")]
    [Description(@"Cash proceeds being reinvested is classified as short term capital gains.")]
    ShortTermCapitalGains,

    /// <summary>
    /// Cash proceeds being reinvested is classified as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_1qeFdTL3EeKU9IrkkToqcw_-1733258337")]
    [Description(@"Cash proceeds being reinvested is classified as return of capital.")]
    ReturnOfCapital,
}
