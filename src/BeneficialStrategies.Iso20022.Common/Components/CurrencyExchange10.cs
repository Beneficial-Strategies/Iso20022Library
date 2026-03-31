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
[IsoId("_UcDvsbppEea_jI1vMH_RbA")]
[DisplayName("Currency Exchange")]
public record CurrencyExchange10
{
    /// <summary>
    /// Indicates the cross currency, if different from the currency of delivery.
    /// </summary>
    [IsoId("_Ul5BI7ppEea_jI1vMH_RbA")]
    [DisplayName("Deliverable Cross Currency")]
    [IsoXmlTag("DlvrblCrossCcy")]
    public ActiveOrHistoricCurrencyCode? DeliverableCrossCurrency { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Ul5BJbppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Forward exchange rate as agreed between the counterparties in the contractual agreement, expressed as a price of base currency in the quoted currency.
    /// </summary>
    [IsoId("_Ul5BJ7ppEea_jI1vMH_RbA")]
    [DisplayName("Forward Exchange Rate")]
    [IsoXmlTag("FwdXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ForwardExchangeRate { get; init; }

    /// <summary>
    /// Indicates the quote base for the exchange rate.
    /// </summary>
    [IsoId("_Ul5BKbppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate Basis")]
    [IsoXmlTag("XchgRateBsis")]
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; }
}
