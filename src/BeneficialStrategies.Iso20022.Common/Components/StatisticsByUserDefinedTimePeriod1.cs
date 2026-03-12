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
[IsoId("_VZJM-tp-Ed-ak6NoX_4Aeg_16395281")]
[DisplayName("Statistics By User Defined Time Period")]
public partial record StatisticsByUserDefinedTimePeriod1
{
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    [IsoId("_VZJM-9p-Ed-ak6NoX_4Aeg_93973909")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required DateTimePeriodDetails Period { get; init; } 
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_VZJM_Np-Ed-ak6NoX_4Aeg_123524743")]
    [DisplayName("Highest Price Value")]
    [IsoXmlTag("HghstPricVal")]
    public PriceValue1? HighestPriceValue { get; init; } 
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_VZJM_dp-Ed-ak6NoX_4Aeg_138301510")]
    [DisplayName("Lowest Price Value")]
    [IsoXmlTag("LwstPricVal")]
    public PriceValue1? LowestPriceValue { get; init; } 
    
    /// <summary>
    /// Change in price since the last valuation.
    /// </summary>
    [IsoId("_VZJM_tp-Ed-ak6NoX_4Aeg_-1933750767")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public PriceValue2? PriceChange { get; init; } 
    
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_VZJM_9p-Ed-ak6NoX_4Aeg_1815898632")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Yield { get; init; } 
    
    
    #nullable disable
    
}
