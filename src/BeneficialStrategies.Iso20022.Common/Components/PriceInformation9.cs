// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_AVrxldokEeC60axPepSq7g_1976702604")]
[DisplayName("Price Information")]
public record PriceInformation9
{
    /// <summary>
    /// Value of the price, for instance, as a currency and value.
    /// </summary>
    [IsoId("_AV1ikNokEeC60axPepSq7g_969887437")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required Price4 Value { get; init; }

    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    [IsoId("_AV1ikdokEeC60axPepSq7g_-1721309790")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime1Choice_? QuotationDate { get; init; }

    /// <summary>
    /// Period during which the price of a security is determined (For outturn securities).
    /// </summary>
    [IsoId("_AV1iktokEeC60axPepSq7g_1341546948")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public DateTimePeriodChoice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_AV1ik9okEeC60axPepSq7g_1577854148")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification77? SourceOfPrice { get; init; }
}
