// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("_VZS989p-Ed-ak6NoX_4Aeg_-616872931")]
[DisplayName("Statistics By Predefined Time Periods")]
public record StatisticsByPredefinedTimePeriods1
{
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    [IsoId("_VZS99Np-Ed-ak6NoX_4Aeg_-80104993")]
    [DisplayName("Highest Price Value 12 Months")]
    [IsoXmlTag("HghstPricVal12Mnths")]
    public PriceValue1? HighestPriceValue12Months { get; init; }

    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    [IsoId("_VZS99dp-Ed-ak6NoX_4Aeg_1198045150")]
    [DisplayName("Lowest Price Value 12 Months")]
    [IsoXmlTag("LwstPricVal12Mnths")]
    public PriceValue1? LowestPriceValue12Months { get; init; }

    /// <summary>
    /// Change in price over a one year period.
    /// </summary>
    [IsoId("_VZS99tp-Ed-ak6NoX_4Aeg_1251612280")]
    [DisplayName("One Year Price Change")]
    [IsoXmlTag("OneYrPricChng")]
    public PriceValue2? OneYearPriceChange { get; init; }

    /// <summary>
    /// Change in price over a three year period.
    /// </summary>
    [IsoId("_VZS999p-Ed-ak6NoX_4Aeg_1282086108")]
    [DisplayName("Three Year Price Change")]
    [IsoXmlTag("ThreeYrPricChng")]
    public PriceValue2? ThreeYearPriceChange { get; init; }

    /// <summary>
    /// Change in price over a five year period.
    /// </summary>
    [IsoId("_VZS9-Np-Ed-ak6NoX_4Aeg_1380901942")]
    [DisplayName("Five Year Price Change")]
    [IsoXmlTag("FiveYrPricChng")]
    public PriceValue2? FiveYearPriceChange { get; init; }
}
