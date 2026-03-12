// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("_Se4bTNp-Ed-ak6NoX_4Aeg_1006320598")]
[DisplayName("Statistics By User Defined Time Period")]
public partial record StatisticsByUserDefinedTimePeriod2
{
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    [IsoId("_Se4bTdp-Ed-ak6NoX_4Aeg_1006320633")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required DateOrDateTimePeriodChoice_ Period { get; init; } 
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_Se4bTtp-Ed-ak6NoX_4Aeg_1006320710")]
    [DisplayName("Highest Price Value")]
    [IsoXmlTag("HghstPricVal")]
    public PriceValue5? HighestPriceValue { get; init; } 
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_Se4bT9p-Ed-ak6NoX_4Aeg_1006320770")]
    [DisplayName("Lowest Price Value")]
    [IsoXmlTag("LwstPricVal")]
    public PriceValue5? LowestPriceValue { get; init; } 
    
    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    [IsoId("_SfCMQNp-Ed-ak6NoX_4Aeg_1006321065")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public PriceValueChange1? PriceChange { get; init; } 
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_SfCMQdp-Ed-ak6NoX_4Aeg_1006321142")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Yield { get; init; } 
    
    
    #nullable disable
    
}
