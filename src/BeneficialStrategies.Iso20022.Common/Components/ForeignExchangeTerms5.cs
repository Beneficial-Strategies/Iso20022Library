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
[IsoId("_U4D5Itp-Ed-ak6NoX_4Aeg_-722166527")]
[DisplayName("Foreign Exchange Terms")]
public record ForeignExchangeTerms5
{
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_U4D5I9p-Ed-ak6NoX_4Aeg_-722166484")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required CurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_U4D5JNp-Ed-ak6NoX_4Aeg_-722166467")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required CurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_U4D5Jdp-Ed-ak6NoX_4Aeg_-722166449")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_U4D5Jtp-Ed-ak6NoX_4Aeg_-722166432")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("_U4D5J9p-Ed-ak6NoX_4Aeg_-722166414")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification2Choice_? QuotingInstitution { get; init; }
}
