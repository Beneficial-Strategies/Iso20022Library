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
[IsoId("__gn0GPSgEeicy5Zn42b9bg")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAmount9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAmount9( ActiveOrHistoricCurrencyAndAmount reqActualMarketValuePostHaircut )
    {
        ActualMarketValuePostHaircut = reqActualMarketValuePostHaircut;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Actual market value post haircut expressed in the collateral currency. 
    /// </summary>
    [IsoId("__gn0H_SgEeicy5Zn42b9bg")]
    [DisplayName("Actual Market Value Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlMktValPstHrcut")]
    #endif
    [IsoXmlTag("ActlMktValPstHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostHaircut { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount ActualMarketValuePostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Actual market value before haircut expressed in the collateral currency.
    /// </summary>
    [IsoId("__gn0HfSgEeicy5Zn42b9bg")]
    [DisplayName("Actual Market Value Before Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlMktValBfrHrcut")]
    #endif
    [IsoXmlTag("ActlMktValBfrHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ActualMarketValueBeforeHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the exposure/collateral in the exposure/collateral currency.
    /// </summary>
    [IsoId("__gn0HvSgEeicy5Zn42b9bg")]
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
    [IsoId("__gn0G_SgEeicy5Zn42b9bg")]
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
    /// Actual market value post haircut expressed in the transaction currency.
    /// </summary>
    [IsoId("__gn0IPSgEeicy5Zn42b9bg")]
    [DisplayName("Market Value Amount Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktValAmtPstHrcut")]
    #endif
    [IsoXmlTag("MktValAmtPstHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountPostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Actual market value before haircut expressed in the transaction currency. 
    /// </summary>
    [IsoId("__gn0HPSgEeicy5Zn42b9bg")]
    [DisplayName("Market Value Amount Before Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktValAmtBfrHrcut")]
    #endif
    [IsoXmlTag("MktValAmtBfrHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MarketValueAmountBeforeHaircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
