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
[IsoId("_-jqBQTkXEem897H7zB2RJg")]
[DisplayName("Price Information25")]
public record PriceInformation25
{
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_-t7-szkXEem897H7zB2RJg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmount4Choice Value { get; init; }

    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    [IsoId("_-t7-uzkXEem897H7zB2RJg")]
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification89? SourceOfPrice { get; init; }

    /// <summary>
    /// Date on which the price is obtained.
    /// </summary>
    [IsoId("_-t7-wzkXEem897H7zB2RJg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice? QuotationDate { get; init; }
}
