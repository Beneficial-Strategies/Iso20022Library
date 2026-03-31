// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_hTyvwf_TEemmj9LO94I0yA")]
[DisplayName("Currency Exchange")]
public record CurrencyExchange15
{
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_hqTLQf_TEemmj9LO94I0yA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public ActiveCurrencyCode? SourceCurrency { get; init; }

    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_hqTLQ__TEemmj9LO94I0yA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public ActiveCurrencyCode? TargetCurrency { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_hqTLRf_TEemmj9LO94I0yA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_hqTLR__TEemmj9LO94I0yA")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; }
}
