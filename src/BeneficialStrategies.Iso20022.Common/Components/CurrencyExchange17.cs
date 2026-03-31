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
[IsoId("_MQkWkQbDEeqrW7Meu5r3kQ")]
[DisplayName("Currency Exchange")]
public record CurrencyExchange17
{
    /// <summary>
    /// Indicates the cross currency, if different from the currency of delivery.
    /// </summary>
    [IsoId("_MYYOwwbDEeqrW7Meu5r3kQ")]
    [DisplayName("Deliverable Cross Currency")]
    [IsoXmlTag("DlvrblCrossCcy")]
    public ActiveOrHistoricCurrencyCode? DeliverableCrossCurrency { get; init; }

    /// <summary>
    /// Indicates the exchange rate between the two currencies specified in the derivative transaction agreed by the counterparties at the inception of the transaction,  expressed as the rate of exchange from converting the unit currency into the quoted currency.
    /// </summary>
    [IsoId("_MYYOxQbDEeqrW7Meu5r3kQ")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? ExchangeRate { get; init; }

    /// <summary>
    /// Forward exchange rate as agreed between the counterparties in the contractual agreement, expressed as a price of base currency in the quoted currency.
    /// </summary>
    [IsoId("_MYYOxwbDEeqrW7Meu5r3kQ")]
    [DisplayName("Forward Exchange Rate")]
    [IsoXmlTag("FwdXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne18Rate)]
    public IsoBaseOne18Rate? ForwardExchangeRate { get; init; }

    /// <summary>
    /// Indicates, for equity options, commodity options and similar products, the currency in which the strike price is denominated.  In case of foreign exchange options, indicates the currency pair and order in which the strike price is expressed as unit currency and quoted currency.
    /// </summary>
    [IsoId("_MYYOyQbDEeqrW7Meu5r3kQ")]
    [DisplayName("Exchange Rate Basis")]
    [IsoXmlTag("XchgRateBsis")]
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; }
}
