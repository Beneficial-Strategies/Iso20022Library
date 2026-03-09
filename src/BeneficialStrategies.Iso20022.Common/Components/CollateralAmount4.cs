// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities collateral position valuation amounts.
/// </summary>
[IsoId("_6b5HwM4FEeiirviLm7P0IA")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAmount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAmount4( ActiveOrHistoricCurrencyAndAmount reqActualMarketValuePostValuationFactor )
    {
        ActualMarketValuePostValuationFactor = reqActualMarketValuePostValuationFactor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Actual market value post valuation factor expressed in the collateral currency (denomination currency of the security). For cash, it is the value post haircut. 
    /// </summary>
    [IsoId("_coNAEM4GEeiirviLm7P0IA")]
    [DisplayName("Actual Market Value Post Valuation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlMktValPstValtnFctr")]
    #endif
    [IsoXmlTag("ActlMktValPstValtnFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostValuationFactor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostValuationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostValuationFactor { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostValuationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Actual market value before valuation factor expressed in the collateral currency (denomination currency of the security). For cash, it is the value before haircut.
    /// </summary>
    [IsoId("_v3K54M4HEeiirviLm7P0IA")]
    [DisplayName("Actual Market Value Before Valuation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlMktValBfrValtnFctr")]
    #endif
    [IsoXmlTag("ActlMktValBfrValtnFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeValuationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeValuationFactor { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeValuationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the exposure/collateral in the exposure/collateral currency.
    /// </summary>
    [IsoId("_kZi1cM4GEeiirviLm7P0IA")]
    [DisplayName("Exposure Collateral In Transaction Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrCollInTxCcy")]
    #endif
    [IsoXmlTag("XpsrCollInTxCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInTransactionCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInTransactionCurrency { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInTransactionCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the exposure/collateral in the reporting currency.
    /// </summary>
    [IsoId("_u_ECoM4GEeiirviLm7P0IA")]
    [DisplayName("Exposure Collateral In Reporting Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrCollInRptgCcy")]
    #endif
    [IsoXmlTag("XpsrCollInRptgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInReportingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInReportingCurrency { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ExposureCollateralInReportingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Market  value post valuation factor expressed in the transaction currency. For cash, it is the value post haircut. 
    /// </summary>
    [IsoId("_GzsVcM4HEeiirviLm7P0IA")]
    [DisplayName("Market Value Amount Post Valuation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktValAmtPstValtnFctr")]
    #endif
    [IsoXmlTag("MktValAmtPstValtnFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostValuationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostValuationFactor { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostValuationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Market value before valuation factor expressed in the transaction currency. For cash, it is the value before haircut.
    /// </summary>
    [IsoId("_TSKBQM4HEeiirviLm7P0IA")]
    [DisplayName("Market Value Amount Before Valuation Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktValAmtBfrValtnFctr")]
    #endif
    [IsoXmlTag("MktValAmtBfrValtnFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeValuationFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeValuationFactor { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeValuationFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [IsoId("_qECsga_fEeqMo4JxiuZGSw")]
    [DisplayName("Total Value Of Own Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlValOfOwnColl")]
    #endif
    [IsoXmlTag("TtlValOfOwnColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [IsoId("_rznzwa_fEeqMo4JxiuZGSw")]
    [DisplayName("Total Value Of Reused Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlValOfReusdColl")]
    #endif
    [IsoXmlTag("TtlValOfReusdColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
