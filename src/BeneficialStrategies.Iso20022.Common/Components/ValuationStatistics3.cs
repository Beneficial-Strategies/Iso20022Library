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
[IsoId("_SeuqT9p-Ed-ak6NoX_4Aeg_578731261")]
[DisplayName("Valuation Statistics")]
public record ValuationStatistics3
{
    /// <summary>
    /// Currency of the valuation statistics.
    /// </summary>
    [IsoId("_SeuqUNp-Ed-ak6NoX_4Aeg_578731305")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    /// <summary>
    /// Type of price from which the change is calculated, eg, bid, offer, or single.
    /// </summary>
    [IsoId("_SeuqUdp-Ed-ak6NoX_4Aeg_578731364")]
    [DisplayName("Price Type Change Basis")]
    [IsoXmlTag("PricTpChngBsis")]
    public required PriceType2 PriceTypeChangeBasis { get; init; }

    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    [IsoId("_SeuqUtp-Ed-ak6NoX_4Aeg_578731434")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public required PriceValueChange1 PriceChange { get; init; }

    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_Se4bQNp-Ed-ak6NoX_4Aeg_578731519")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Yield { get; init; }

    /// <summary>
    /// Information related to price variations, expressed using pre-defined periods.
    /// </summary>
    [IsoId("_Se4bQdp-Ed-ak6NoX_4Aeg_578731849")]
    [DisplayName("By Predefined Time Periods")]
    [IsoXmlTag("ByPrdfndTmPrds")]
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; init; }

    /// <summary>
    /// Information related to price variations, expressed using user-defined periods.
    /// </summary>
    [IsoId("_Se4bQtp-Ed-ak6NoX_4Aeg_579651898")]
    [DisplayName("By User Defined Time Period")]
    [IsoXmlTag("ByUsrDfndTmPrd")]
    public ValueList<StatisticsByUserDefinedTimePeriod2> ByUserDefinedTimePeriod { get; init; } =
        [];
}
