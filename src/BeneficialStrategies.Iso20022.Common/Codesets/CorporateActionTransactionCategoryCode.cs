// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10mR0TL3EeKU9IrkkToqcw_816572354")]
[Description(@"Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.")]
[Derivations(typeof(CorporateActionTransactionCategory1Code))]
public enum CorporateActionTransactionCategoryCode
{
    /// <summary>
    /// Reported event types belong to the cash dividend category.
    /// Encoded/decoded by serializers as &quot;TC05&quot;.
    /// </summary>
    [EnumMember(Value = "TC05")]
    [IsoId("_10mR0jL3EeKU9IrkkToqcw_295524603")]
    [Description(@"Reported event types belong to the cash dividend category.")]
    CashDividend,
    
    /// <summary>
    /// Reported event types belong to the unit Investment trust security category.
    /// Encoded/decoded by serializers as &quot;TC10&quot;.
    /// </summary>
    [EnumMember(Value = "TC10")]
    [IsoId("_10mR0zL3EeKU9IrkkToqcw_169205975")]
    [Description(@"Reported event types belong to the unit Investment trust security category.")]
    UnitInvestmentTrustSecurity,
    
    /// <summary>
    /// Reported event types belong to the straight through processing category.
    /// Encoded/decoded by serializers as &quot;TC15&quot;.
    /// </summary>
    [EnumMember(Value = "TC15")]
    [IsoId("_10mR1DL3EeKU9IrkkToqcw_1316142399")]
    [Description(@"Reported event types belong to the straight through processing category.")]
    PassThrough,
    
    /// <summary>
    /// Reported event types belong to the corporate bond category.
    /// Encoded/decoded by serializers as &quot;TC20&quot;.
    /// </summary>
    [EnumMember(Value = "TC20")]
    [IsoId("_10mR1TL3EeKU9IrkkToqcw_-635496643")]
    [Description(@"Reported event types belong to the corporate bond category.")]
    CorporateBond,
    
    /// <summary>
    /// Reported event types belong to the municipal bond category.
    /// Encoded/decoded by serializers as &quot;TC25&quot;.
    /// </summary>
    [EnumMember(Value = "TC25")]
    [IsoId("_10wC0DL3EeKU9IrkkToqcw_1465628716")]
    [Description(@"Reported event types belong to the municipal bond category.")]
    MunicipalBond,
    
    /// <summary>
    /// Reported event types belong to the stock distribution category.
    /// Encoded/decoded by serializers as &quot;TC30&quot;.
    /// </summary>
    [EnumMember(Value = "TC30")]
    [IsoId("_10wC0TL3EeKU9IrkkToqcw_-1339665636")]
    [Description(@"Reported event types belong to the stock distribution category.")]
    StockDistribution,
    
    /// <summary>
    /// Reported event types belong to the optional dividend category.
    /// Encoded/decoded by serializers as &quot;TC35&quot;.
    /// </summary>
    [EnumMember(Value = "TC35")]
    [IsoId("_10wC0jL3EeKU9IrkkToqcw_-618792501")]
    [Description(@"Reported event types belong to the optional dividend category.")]
    OptionalDividend,
    
    /// <summary>
    /// Reported event types belong to the foreign record date notice category.
    /// Encoded/decoded by serializers as &quot;TC38&quot;.
    /// </summary>
    [EnumMember(Value = "TC38")]
    [IsoId("_10wC0zL3EeKU9IrkkToqcw_-1026905461")]
    [Description(@"Reported event types belong to the foreign record date notice category.")]
    ForeignRecordDateNotice,
    
    /// <summary>
    /// Reported event types belong to the dividend reinvestment category.
    /// Encoded/decoded by serializers as &quot;TC40&quot;.
    /// </summary>
    [EnumMember(Value = "TC40")]
    [IsoId("_10wC1DL3EeKU9IrkkToqcw_-735047675")]
    [Description(@"Reported event types belong to the dividend reinvestment category.")]
    DividendReinvestment,
    
    /// <summary>
    /// Reported event types belong to the tax exempt dividend service category.
    /// Encoded/decoded by serializers as &quot;TC41&quot;.
    /// </summary>
    [EnumMember(Value = "TC41")]
    [IsoId("_10wC1TL3EeKU9IrkkToqcw_-1146540894")]
    [Description(@"Reported event types belong to the tax exempt dividend service category.")]
    TaxExemptDividendService,
    
    /// <summary>
    /// Reported event types belong to the direct registration service category.
    /// Encoded/decoded by serializers as &quot;TC42&quot;.
    /// </summary>
    [EnumMember(Value = "TC42")]
    [IsoId("_10wC1jL3EeKU9IrkkToqcw_1274107323")]
    [Description(@"Reported event types belong to the direct registration service category.")]
    DirectRegistrationService,
    
    /// <summary>
    /// Reported event types belong to the special distribution category.
    /// Encoded/decoded by serializers as &quot;TC43&quot;.
    /// </summary>
    [EnumMember(Value = "TC43")]
    [IsoId("_105MwDL3EeKU9IrkkToqcw_-461029013")]
    [Description(@"Reported event types belong to the special distribution category.")]
    SpecialDistribution,
    
    /// <summary>
    /// Reported event types belong to the reorganisation category.
    /// Encoded/decoded by serializers as &quot;TC45&quot;.
    /// </summary>
    [EnumMember(Value = "TC45")]
    [IsoId("_105MwTL3EeKU9IrkkToqcw_1089089162")]
    [Description(@"Reported event types belong to the reorganisation category.")]
    Reorganisation,
    
    /// <summary>
    /// Reported event types belong to the recapitalization record date notice category.
    /// Encoded/decoded by serializers as &quot;TC46&quot;.
    /// </summary>
    [EnumMember(Value = "TC46")]
    [IsoId("_105MwjL3EeKU9IrkkToqcw_-551354191")]
    [Description(@"Reported event types belong to the recapitalization record date notice category.")]
    RecapitalizationRecordDateNotice,
    
    /// <summary>
    /// Reported event types belong to the liquidation record date notice category.
    /// Encoded/decoded by serializers as &quot;TC47&quot;.
    /// </summary>
    [EnumMember(Value = "TC47")]
    [IsoId("_105MwzL3EeKU9IrkkToqcw_-324879133")]
    [Description(@"Reported event types belong to the liquidation record date notice category.")]
    LiquidationRecordDateNotice,
    
    /// <summary>
    /// Reported event types belong to the sales of assets record date notice category.
    /// Encoded/decoded by serializers as &quot;TC48&quot;.
    /// </summary>
    [EnumMember(Value = "TC48")]
    [IsoId("_105MxDL3EeKU9IrkkToqcw_1678246298")]
    [Description(@"Reported event types belong to the sales of assets record date notice category.")]
    SalesOfAssetsRecordDateNotice,
    
    /// <summary>
    /// Reported event types belong to the redemptions record date notice category.
    /// Encoded/decoded by serializers as &quot;TC49&quot;.
    /// </summary>
    [EnumMember(Value = "TC49")]
    [IsoId("_105MxTL3EeKU9IrkkToqcw_-1493909535")]
    [Description(@"Reported event types belong to the redemptions record date notice category.")]
    RedemptionsRecordDateNotice,
    
}
