// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_ylo6pDkYEem897H7zB2RJg")]
[DisplayName("Foreign Exchange Rate3")]
public record ForeignExchangeRate3
{
    /// <summary>
    /// Value of one currency expressed in relation to another currency.
    /// </summary>
    [IsoId("_ylo6pTkYEem897H7zB2RJg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange.
    /// </summary>
    [IsoId("_ylo6pjkYEem897H7zB2RJg")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_ylo6pzkYEem897H7zB2RJg")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveCurrencyCode? QuotedCurrency { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_D22jwTkZEem897H7zB2RJg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; }
}
