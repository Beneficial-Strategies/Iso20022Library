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
[IsoId("_VZADBtp-Ed-ak6NoX_4Aeg_1063188298")]
[DisplayName("Valuation Statistics")]
public record ValuationStatistics2
{
    /// <summary>
    /// Currency of the valuation statistics.
    /// </summary>
    [IsoId("_VZADB9p-Ed-ak6NoX_4Aeg_1063188713")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    /// <summary>
    /// Type of price from which the change is calculated, eg, bid, offer, or single.
    /// </summary>
    [IsoId("_VZADCNp-Ed-ak6NoX_4Aeg_1063189091")]
    [DisplayName("Price Type Change Basis")]
    [IsoXmlTag("PricTpChngBsis")]
    public required PriceType2 PriceTypeChangeBasis { get; init; }

    /// <summary>
    /// Change in price since the last valuation.
    /// </summary>
    [IsoId("_VZADCdp-Ed-ak6NoX_4Aeg_1063189133")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public required PriceValue2 PriceChange { get; init; }

    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [IsoId("_VZADCtp-Ed-ak6NoX_4Aeg_1063189246")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Yield { get; init; }

    /// <summary>
    /// Information related to price variations, expressed using pre-defined periods.
    /// </summary>
    [IsoId("_VZADC9p-Ed-ak6NoX_4Aeg_1897040847")]
    [DisplayName("By Predefined Time Periods")]
    [IsoXmlTag("ByPrdfndTmPrds")]
    public StatisticsByPredefinedTimePeriods1? ByPredefinedTimePeriods { get; init; }

    /// <summary>
    /// Information related to price variations, expressed using user-defined periods.
    /// </summary>
    [IsoId("_VZJM8Np-Ed-ak6NoX_4Aeg_1063190202")]
    [DisplayName("By User Defined Time Period")]
    [IsoXmlTag("ByUsrDfndTmPrd")]
    public StatisticsByUserDefinedTimePeriod1? ByUserDefinedTimePeriod { get; init; }
}
