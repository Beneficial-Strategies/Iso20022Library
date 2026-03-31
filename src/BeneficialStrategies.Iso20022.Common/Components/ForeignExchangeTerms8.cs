// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the terms of the foreign exchange transaction.
/// </summary>
[IsoId("_QLzlZtp-Ed-ak6NoX_4Aeg_-244208609")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms8
{
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLzlZ9p-Ed-ak6NoX_4Aeg_157524165")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_QL9WYNp-Ed-ak6NoX_4Aeg_157524196")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QL9WYdp-Ed-ak6NoX_4Aeg_157524226")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Amount of money resulting from a foreign exchange transaction.
    /// </summary>
    [IsoId("_QL9WYtp-Ed-ak6NoX_4Aeg_-176260697")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required ActiveCurrencyAndAmount ResultingAmount { get; init; }
}
