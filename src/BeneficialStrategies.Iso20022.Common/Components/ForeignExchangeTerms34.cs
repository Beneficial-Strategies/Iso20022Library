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
[IsoId("_8d-7m9LCEeiN28wlpBQScw")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms34
{
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_8vPDM9LCEeiN28wlpBQScw")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_8vPDNdLCEeiN28wlpBQScw")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_8vPDN9LCEeiN28wlpBQScw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_8vPDP9LCEeiN28wlpBQScw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_8vPDR9LCEeiN28wlpBQScw")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification120Choice_? QuotingInstitution { get; init; }
}
