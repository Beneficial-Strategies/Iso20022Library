// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11C9wDL3EeKU9IrkkToqcw_485268367")]
[Description(
    @"Specifies the transaction category to which the corporate action event type belongs to for reporting purposes."
)]
[DerivedFrom(typeof(CorporateActionTransactionCategoryCode))]
public enum CorporateActionTransactionCategory1Code
{
    /// <summary>
    /// Reported event types belong to the cash dividend category.
    /// Encoded/decoded by serializers as &quot;TC05&quot;.
    /// </summary>
    [EnumMember(Value = "TC05")]
    [IsoId("_11C9wTL3EeKU9IrkkToqcw_-892482550")]
    [Description(@"Reported event types belong to the cash dividend category.")]
    CashDividend = CorporateActionTransactionCategoryCode.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the unit Investment trust security category.
    /// Encoded/decoded by serializers as &quot;TC10&quot;.
    /// </summary>
    [EnumMember(Value = "TC10")]
    [IsoId("_11C9wjL3EeKU9IrkkToqcw_-306535524")]
    [Description(@"Reported event types belong to the unit Investment trust security category.")]
    UnitInvestmentTrustSecurity =
        CorporateActionTransactionCategoryCode.UnitInvestmentTrustSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the straight through processing category.
    /// Encoded/decoded by serializers as &quot;TC15&quot;.
    /// </summary>
    [EnumMember(Value = "TC15")]
    [IsoId("_11C9wzL3EeKU9IrkkToqcw_-725069114")]
    [Description(@"Reported event types belong to the straight through processing category.")]
    PassThrough = CorporateActionTransactionCategoryCode.PassThrough, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the corporate bond category.
    /// Encoded/decoded by serializers as &quot;TC20&quot;.
    /// </summary>
    [EnumMember(Value = "TC20")]
    [IsoId("_11C9xDL3EeKU9IrkkToqcw_-1360100960")]
    [Description(@"Reported event types belong to the corporate bond category.")]
    CorporateBond = CorporateActionTransactionCategoryCode.CorporateBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the municipal bond category.
    /// Encoded/decoded by serializers as &quot;TC25&quot;.
    /// </summary>
    [EnumMember(Value = "TC25")]
    [IsoId("_11C9xTL3EeKU9IrkkToqcw_107047803")]
    [Description(@"Reported event types belong to the municipal bond category.")]
    MunicipalBond = CorporateActionTransactionCategoryCode.MunicipalBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the stock distribution category.
    /// Encoded/decoded by serializers as &quot;TC30&quot;.
    /// </summary>
    [EnumMember(Value = "TC30")]
    [IsoId("_11C9xjL3EeKU9IrkkToqcw_-282080622")]
    [Description(@"Reported event types belong to the stock distribution category.")]
    StockDistribution = CorporateActionTransactionCategoryCode.StockDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the optional dividend category.
    /// Encoded/decoded by serializers as &quot;TC35&quot;.
    /// </summary>
    [EnumMember(Value = "TC35")]
    [IsoId("_11MuwDL3EeKU9IrkkToqcw_1548842547")]
    [Description(@"Reported event types belong to the optional dividend category.")]
    OptionalDividend = CorporateActionTransactionCategoryCode.OptionalDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the foreign record date notice category.
    /// Encoded/decoded by serializers as &quot;TC38&quot;.
    /// </summary>
    [EnumMember(Value = "TC38")]
    [IsoId("_11MuwTL3EeKU9IrkkToqcw_2002929816")]
    [Description(@"Reported event types belong to the foreign record date notice category.")]
    ForeignRecordDateNotice = CorporateActionTransactionCategoryCode.ForeignRecordDateNotice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the dividend reinvestment category.
    /// Encoded/decoded by serializers as &quot;TC40&quot;.
    /// </summary>
    [EnumMember(Value = "TC40")]
    [IsoId("_11MuwjL3EeKU9IrkkToqcw_-1531272327")]
    [Description(@"Reported event types belong to the dividend reinvestment category.")]
    DividendReinvestment = CorporateActionTransactionCategoryCode.DividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the tax exempt dividend service category.
    /// Encoded/decoded by serializers as &quot;TC41&quot;.
    /// </summary>
    [EnumMember(Value = "TC41")]
    [IsoId("_11MuwzL3EeKU9IrkkToqcw_-64123564")]
    [Description(@"Reported event types belong to the tax exempt dividend service category.")]
    TaxExemptDividendService = CorporateActionTransactionCategoryCode.TaxExemptDividendService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the direct registration service category.
    /// Encoded/decoded by serializers as &quot;TC42&quot;.
    /// </summary>
    [EnumMember(Value = "TC42")]
    [IsoId("_11MuxDL3EeKU9IrkkToqcw_-1252003185")]
    [Description(@"Reported event types belong to the direct registration service category.")]
    DirectRegistrationService = CorporateActionTransactionCategoryCode.DirectRegistrationService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the special distribution category.
    /// Encoded/decoded by serializers as &quot;TC43&quot;.
    /// </summary>
    [EnumMember(Value = "TC43")]
    [IsoId("_11MuxTL3EeKU9IrkkToqcw_-776602817")]
    [Description(@"Reported event types belong to the special distribution category.")]
    SpecialDistribution = CorporateActionTransactionCategoryCode.SpecialDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the reorganisation category.
    /// Encoded/decoded by serializers as &quot;TC45&quot;.
    /// </summary>
    [EnumMember(Value = "TC45")]
    [IsoId("_11MuxjL3EeKU9IrkkToqcw_-787701594")]
    [Description(@"Reported event types belong to the reorganisation category.")]
    Reorganisation = CorporateActionTransactionCategoryCode.Reorganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the recapitalization record date notice category.
    /// Encoded/decoded by serializers as &quot;TC46&quot;.
    /// </summary>
    [EnumMember(Value = "TC46")]
    [IsoId("_11V4sDL3EeKU9IrkkToqcw_1201252015")]
    [Description(
        @"Reported event types belong to the recapitalization record date notice category."
    )]
    RecapitalizationRecordDateNotice =
        CorporateActionTransactionCategoryCode.RecapitalizationRecordDateNotice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the liquidation record date notice category.
    /// Encoded/decoded by serializers as &quot;TC47&quot;.
    /// </summary>
    [EnumMember(Value = "TC47")]
    [IsoId("_11V4sTL3EeKU9IrkkToqcw_-1626566518")]
    [Description(@"Reported event types belong to the liquidation record date notice category.")]
    LiquidationRecordDateNotice =
        CorporateActionTransactionCategoryCode.LiquidationRecordDateNotice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the sales of assets record date notice category.
    /// Encoded/decoded by serializers as &quot;TC48&quot;.
    /// </summary>
    [EnumMember(Value = "TC48")]
    [IsoId("_11V4sjL3EeKU9IrkkToqcw_1461623903")]
    [Description(
        @"Reported event types belong to the sales of assets record date notice category."
    )]
    SalesOfAssetsRecordDateNotice =
        CorporateActionTransactionCategoryCode.SalesOfAssetsRecordDateNotice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported event types belong to the redemptions record date notice category.
    /// Encoded/decoded by serializers as &quot;TC49&quot;.
    /// </summary>
    [EnumMember(Value = "TC49")]
    [IsoId("_11V4szL3EeKU9IrkkToqcw_151444510")]
    [Description(@"Reported event types belong to the redemptions record date notice category.")]
    RedemptionsRecordDateNotice =
        CorporateActionTransactionCategoryCode.RedemptionsRecordDateNotice, // same ordinal as derivation source for type conversions
}
