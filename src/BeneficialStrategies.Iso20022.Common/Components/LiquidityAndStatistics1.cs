// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ability of a financial instrument to be easily traded and converted to cash, at conditions that do not affect its price.
/// </summary>
[IsoId("_SW1Shdp-Ed-ak6NoX_4Aeg_-268744168")]
[DisplayName("Liquidity And Statistics")]
public partial record LiquidityAndStatistics1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether an amount is a gross amount (including all charges, commissions and tax), or a net amount.
    /// </summary>
    [IsoId("_SW1Shtp-Ed-ak6NoX_4Aeg_823585447")]
    [DisplayName("Gross Indicator")]
    [IsoXmlTag("GrssInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator GrossIndicator { get; init; } 
    
    /// <summary>
    /// Type of liquidity measure, of a financial instrument, on a market.
    /// </summary>
    [IsoId("_SW1Sh9p-Ed-ak6NoX_4Aeg_620603298")]
    [DisplayName("Indicator Type")]
    [IsoXmlTag("IndTp")]
    public required LiquidityIndicatorType1Code IndicatorType { get; init; } 
    
    /// <summary>
    /// Indicates the overall weighted average liquidity expressed as a percentage of average daily volume.
    /// </summary>
    [IsoId("_SW1SiNp-Ed-ak6NoX_4Aeg_880114594")]
    [DisplayName("Weighted Average Liquidity")]
    [IsoXmlTag("WghtdAvrgLqdty")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate WeightedAverageLiquidity { get; init; } 
    
    /// <summary>
    /// Accepted value of stocks composing an index located outside its country of origin.
    /// </summary>
    [IsoId("_SW1Sidp-Ed-ak6NoX_4Aeg_936447934")]
    [DisplayName("Out Main Country Index")]
    [IsoXmlTag("OutMainCtryIndx")]
    public required ActiveCurrencyAndAmount OutMainCountryIndex { get; init; } 
    
    /// <summary>
    /// Percentage of program that crosses in Currency.
    /// </summary>
    [IsoId("_SW1Sitp-Ed-ak6NoX_4Aeg_1407444508")]
    [DisplayName("Cross Percent")]
    [IsoXmlTag("CrossPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CrossPercent { get; init; } 
    
    /// <summary>
    /// SideValue1 is used to show the monetary total value in either direction (buy or sell) of the transaction without revealing whether it is the buy-side institutions intention to buy or sell.
    /// </summary>
    [IsoId("_SW1Si9p-Ed-ak6NoX_4Aeg_58180983")]
    [DisplayName("Side Value")]
    [IsoXmlTag("SdVal1")]
    public ActiveCurrencyAndAmount? SideValue1 { get; init; } 
    
    /// <summary>
    /// SideValue2 is used to show the monetary total value in either direction (buy or sell) of the transaction without revealing whether it is the buy-side institutions intention to buy or sell.
    /// </summary>
    [IsoId("_SW1SjNp-Ed-ak6NoX_4Aeg_89580521")]
    [DisplayName("Side Value")]
    [IsoXmlTag("SdVal2")]
    public ActiveCurrencyAndAmount? SideValue2 { get; init; } 
    
    
    #nullable disable
    
}
