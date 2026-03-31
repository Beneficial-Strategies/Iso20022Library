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
[IsoId("_aDZy8SSEEeWdoOFYMt-Lzw")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms26
{
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    [IsoId("_afFCUySEEeWdoOFYMt-Lzw")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public ActiveCurrencyAnd13DecimalAmount? ToAmount { get; init; }

    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    [IsoId("_afFCVSSEEeWdoOFYMt-Lzw")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public ActiveCurrencyAndAmount? FromAmount { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_afFCVySEEeWdoOFYMt-Lzw")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_afFCWSSEEeWdoOFYMt-Lzw")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_afFCWySEEeWdoOFYMt-Lzw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_afFCYySEEeWdoOFYMt-Lzw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_afFCZSSEEeWdoOFYMt-Lzw")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification70Choice_? QuotingInstitution { get; init; }
}
