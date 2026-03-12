// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities collateral position valuation amounts.
/// </summary>
[IsoId("_6b5HwM4FEeiirviLm7P0IA")]
[DisplayName("Collateral Amount")]
public partial record CollateralAmount4
{
    #nullable enable
    
    /// <summary>
    /// Actual market value post valuation factor expressed in the collateral currency (denomination currency of the security). For cash, it is the value post haircut. 
    /// </summary>
    [IsoId("_coNAEM4GEeiirviLm7P0IA")]
    [DisplayName("Actual Market Value Post Valuation Factor")]
    [IsoXmlTag("ActlMktValPstValtnFctr")]
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostValuationFactor { get; init; } 
    
    /// <summary>
    /// Actual market value before valuation factor expressed in the collateral currency (denomination currency of the security). For cash, it is the value before haircut.
    /// </summary>
    [IsoId("_v3K54M4HEeiirviLm7P0IA")]
    [DisplayName("Actual Market Value Before Valuation Factor")]
    [IsoXmlTag("ActlMktValBfrValtnFctr")]
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeValuationFactor { get; init; } 
    
    /// <summary>
    /// Amount of the exposure/collateral in the exposure/collateral currency.
    /// </summary>
    [IsoId("_kZi1cM4GEeiirviLm7P0IA")]
    [DisplayName("Exposure Collateral In Transaction Currency")]
    [IsoXmlTag("XpsrCollInTxCcy")]
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInTransactionCurrency { get; init; } 
    
    /// <summary>
    /// Amount of the exposure/collateral in the reporting currency.
    /// </summary>
    [IsoId("_u_ECoM4GEeiirviLm7P0IA")]
    [DisplayName("Exposure Collateral In Reporting Currency")]
    [IsoXmlTag("XpsrCollInRptgCcy")]
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInReportingCurrency { get; init; } 
    
    /// <summary>
    /// Market  value post valuation factor expressed in the transaction currency. For cash, it is the value post haircut. 
    /// </summary>
    [IsoId("_GzsVcM4HEeiirviLm7P0IA")]
    [DisplayName("Market Value Amount Post Valuation Factor")]
    [IsoXmlTag("MktValAmtPstValtnFctr")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostValuationFactor { get; init; } 
    
    /// <summary>
    /// Market value before valuation factor expressed in the transaction currency. For cash, it is the value before haircut.
    /// </summary>
    [IsoId("_TSKBQM4HEeiirviLm7P0IA")]
    [DisplayName("Market Value Amount Before Valuation Factor")]
    [IsoXmlTag("MktValAmtBfrValtnFctr")]
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeValuationFactor { get; init; } 
    
    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [IsoId("_qECsga_fEeqMo4JxiuZGSw")]
    [DisplayName("Total Value Of Own Collateral")]
    [IsoXmlTag("TtlValOfOwnColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    
    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [IsoId("_rznzwa_fEeqMo4JxiuZGSw")]
    [DisplayName("Total Value Of Reused Collateral")]
    [IsoXmlTag("TtlValOfReusdColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    
    
    #nullable disable
    
}
