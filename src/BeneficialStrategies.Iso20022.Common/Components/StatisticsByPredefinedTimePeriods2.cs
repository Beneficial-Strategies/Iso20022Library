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
[IsoId("_SfCMQtp-Ed-ak6NoX_4Aeg_664619223")]
[DisplayName("Statistics By Predefined Time Periods")]
public partial record StatisticsByPredefinedTimePeriods2
{
    #nullable enable
    
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_SfCMQ9p-Ed-ak6NoX_4Aeg_664619259")]
    [DisplayName("Highest Price Value 12 Months")]
    [IsoXmlTag("HghstPricVal12Mnths")]
    public PriceValue5? HighestPriceValue12Months { get; init; } 
    
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_SfCMRNp-Ed-ak6NoX_4Aeg_665539367")]
    [DisplayName("Lowest Price Value 12 Months")]
    [IsoXmlTag("LwstPricVal12Mnths")]
    public PriceValue5? LowestPriceValue12Months { get; init; } 
    
    /// <summary>
    /// Change in price over a one year period.
    /// </summary>
    [IsoId("_SfCMRdp-Ed-ak6NoX_4Aeg_665539618")]
    [DisplayName("One Year Price Change")]
    [IsoXmlTag("OneYrPricChng")]
    public PriceValueChange1? OneYearPriceChange { get; init; } 
    
    /// <summary>
    /// Change in price over a three year period.
    /// </summary>
    [IsoId("_SfCMRtp-Ed-ak6NoX_4Aeg_665539990")]
    [DisplayName("Three Year Price Change")]
    [IsoXmlTag("ThreeYrPricChng")]
    public PriceValueChange1? ThreeYearPriceChange { get; init; } 
    
    /// <summary>
    /// Change in price over a five year period.
    /// </summary>
    [IsoId("_SfCMR9p-Ed-ak6NoX_4Aeg_665540323")]
    [DisplayName("Five Year Price Change")]
    [IsoXmlTag("FiveYrPricChng")]
    public PriceValueChange1? FiveYearPriceChange { get; init; } 
    
    
    #nullable disable
    
}
