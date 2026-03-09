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
/// Provides information about the collateral valuation such as the collateral amount, the market value.
/// </summary>
[IsoId("_vWhlQ6MOEeCojJW5vEuTEQ_1855607436")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAmount1( ActiveCurrencyAndAmount reqCollateralAmount,ActiveCurrencyAndAmount reqReportedCurrencyAndAmount,ActiveCurrencyAndAmount reqMarketValueAmount )
    {
        CollateralAmount = reqCollateralAmount;
        ReportedCurrencyAndAmount = reqReportedCurrencyAndAmount;
        MarketValueAmount = reqMarketValueAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the total amount of the collateral in the collateral currency.
    /// </summary>
    [IsoId("_vWhlRKMOEeCojJW5vEuTEQ_14047154")]
    [DisplayName("Collateral Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAmt")]
    #endif
    [IsoXmlTag("CollAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total amount of the collateral in the reporting currency.
    /// </summary>
    [IsoId("_vWhlRaMOEeCojJW5vEuTEQ_-838505809")]
    [DisplayName("Reported Currency And Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdCcyAndAmt")]
    #endif
    [IsoXmlTag("RptdCcyAndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ReportedCurrencyAndAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total market to market value of the collateral in the reporting currency. It is the dirty price, that is, the accrued interest is included if any.
    /// </summary>
    [IsoId("_vWhlRqMOEeCojJW5vEuTEQ_-509144164")]
    [DisplayName("Market Value Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktValAmt")]
    #endif
    [IsoXmlTag("MktValAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MarketValueAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MarketValueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MarketValueAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount MarketValueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the accrued interest on the value of the collateral in the currency of the collateral.
    /// </summary>
    [IsoId("_vWhlR6MOEeCojJW5vEuTEQ_2039101812")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money paid for the provision of financial services.
    /// </summary>
    [IsoId("_vWqvMKMOEeCojJW5vEuTEQ_-1928237919")]
    [DisplayName("Fees And Commissions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeesAndComssns")]
    #endif
    [IsoXmlTag("FeesAndComssns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FeesAndCommissions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FeesAndCommissions { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FeesAndCommissions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
