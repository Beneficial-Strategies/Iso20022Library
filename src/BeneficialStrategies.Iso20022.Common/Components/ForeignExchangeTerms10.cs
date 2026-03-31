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
[IsoId("_WKBQTtp-Ed-ak6NoX_4Aeg_-117785638")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms10
{
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    [IsoId("_WKBQT9p-Ed-ak6NoX_4Aeg_-117785546")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? ToAmount { get; init; }

    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    [IsoId("_WKBQUNp-Ed-ak6NoX_4Aeg_-117785606")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FromAmount { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_WKBQUdp-Ed-ak6NoX_4Aeg_-117785515")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_WKLBQNp-Ed-ak6NoX_4Aeg_-117785206")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_WKLBQdp-Ed-ak6NoX_4Aeg_-117785175")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }
}
