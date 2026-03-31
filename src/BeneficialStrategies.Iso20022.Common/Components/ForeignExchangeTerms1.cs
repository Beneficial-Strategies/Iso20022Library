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
[IsoId("_QK6Nitp-Ed-ak6NoX_4Aeg_651798512")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms1
{
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QK6Ni9p-Ed-ak6NoX_4Aeg_829917184")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_QK6NjNp-Ed-ak6NoX_4Aeg_537959446")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QK6Njdp-Ed-ak6NoX_4Aeg_-1997901349")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_QK6Njtp-Ed-ak6NoX_4Aeg_-345273841")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_QLD-gNp-Ed-ak6NoX_4Aeg_1299993594")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification10Choice_? QuotingInstitution { get; init; }
}
