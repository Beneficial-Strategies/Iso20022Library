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
/// Ability of a financial instrument to be easily traded and converted to cash, at conditions that do not affect its price.
/// </summary>
[IsoId("_SW1Shdp-Ed-ak6NoX_4Aeg_-268744168")]
[DisplayName("Liquidity And Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityAndStatistics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityAndStatistics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityAndStatistics1( System.String reqGrossIndicator,LiquidityIndicatorType1Code reqIndicatorType,System.Decimal reqWeightedAverageLiquidity,ActiveCurrencyAndAmount reqOutMainCountryIndex )
    {
        GrossIndicator = reqGrossIndicator;
        IndicatorType = reqIndicatorType;
        WeightedAverageLiquidity = reqWeightedAverageLiquidity;
        OutMainCountryIndex = reqOutMainCountryIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether an amount is a gross amount (including all charges, commissions and tax), or a net amount.
    /// </summary>
    [IsoId("_SW1Shtp-Ed-ak6NoX_4Aeg_823585447")]
    [DisplayName("Gross Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssInd")]
    #endif
    [IsoXmlTag("GrssInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator GrossIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GrossIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GrossIndicator { get; init; } 
    #else
    public System.String GrossIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of liquidity measure, of a financial instrument, on a market.
    /// </summary>
    [IsoId("_SW1Sh9p-Ed-ak6NoX_4Aeg_620603298")]
    [DisplayName("Indicator Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndTp")]
    #endif
    [IsoXmlTag("IndTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LiquidityIndicatorType1Code IndicatorType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LiquidityIndicatorType1Code IndicatorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidityIndicatorType1Code IndicatorType { get; init; } 
    #else
    public LiquidityIndicatorType1Code IndicatorType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the overall weighted average liquidity expressed as a percentage of average daily volume.
    /// </summary>
    [IsoId("_SW1SiNp-Ed-ak6NoX_4Aeg_880114594")]
    [DisplayName("Weighted Average Liquidity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WghtdAvrgLqdty")]
    #endif
    [IsoXmlTag("WghtdAvrgLqdty")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate WeightedAverageLiquidity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal WeightedAverageLiquidity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal WeightedAverageLiquidity { get; init; } 
    #else
    public System.Decimal WeightedAverageLiquidity { get; set; } 
    #endif
    
    /// <summary>
    /// Accepted value of stocks composing an index located outside its country of origin.
    /// </summary>
    [IsoId("_SW1Sidp-Ed-ak6NoX_4Aeg_936447934")]
    [DisplayName("Out Main Country Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutMainCtryIndx")]
    #endif
    [IsoXmlTag("OutMainCtryIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OutMainCountryIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OutMainCountryIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OutMainCountryIndex { get; init; } 
    #else
    public ActiveCurrencyAndAmount OutMainCountryIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of program that crosses in Currency.
    /// </summary>
    [IsoId("_SW1Sitp-Ed-ak6NoX_4Aeg_1407444508")]
    [DisplayName("Cross Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrossPct")]
    #endif
    [IsoXmlTag("CrossPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CrossPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CrossPercent { get; init; } 
    #else
    public System.Decimal? CrossPercent { get; set; } 
    #endif
    
    /// <summary>
    /// SideValue1 is used to show the monetary total value in either direction (buy or sell) of the transaction without revealing whether it is the buy-side institutions intention to buy or sell.
    /// </summary>
    [IsoId("_SW1Si9p-Ed-ak6NoX_4Aeg_58180983")]
    [DisplayName("Side Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdVal1")]
    #endif
    [IsoXmlTag("SdVal1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SideValue1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SideValue1 { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SideValue1 { get; set; } 
    #endif
    
    /// <summary>
    /// SideValue2 is used to show the monetary total value in either direction (buy or sell) of the transaction without revealing whether it is the buy-side institutions intention to buy or sell.
    /// </summary>
    [IsoId("_SW1SjNp-Ed-ak6NoX_4Aeg_89580521")]
    [DisplayName("Side Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdVal2")]
    #endif
    [IsoXmlTag("SdVal2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SideValue2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SideValue2 { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SideValue2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
