// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the foreign exchange.
/// </summary>
[IsoId("_8F9mqLu7EeSXxOgurgHGgw")]
[DisplayName("Foreign Exchange")]
public record ForeignExchange1
{
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_8F9mrLu7EeSXxOgurgHGgw")]
    [DisplayName("Foreign Currency")]
    [IsoXmlTag("FrgnCcy")]
    public required ActiveOrHistoricCurrencyCode ForeignCurrency { get; init; }

    /// <summary>
    /// Foreign exchange rate between the source and the foreign currency applicable to the first leg of the FX swap transaction. The foreign exchange spot rate will be reported as the number of foreign currency units per one unit of the source currency.
    /// </summary>
    [IsoId("_8F9mq7u7EeSXxOgurgHGgw")]
    [DisplayName("Exchange Spot Rate")]
    [IsoXmlTag("XchgSpotRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeSpotRate { get; init; }

    /// <summary>
    /// Difference between the foreign exchange spot rate and the foreign exchange forward rate expressed in basis points quoted in accordance with the prevailing market conventions for the currency pair.
    /// Usage:
    /// This value can be either positive or negative.
    /// </summary>
    [IsoId("_c1A2wLu8EeSXxOgurgHGgw")]
    [DisplayName("Exchange Forward Point")]
    [IsoXmlTag("XchgFwdPt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber ExchangeForwardPoint { get; init; }
}
