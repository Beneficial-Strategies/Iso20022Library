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
[IsoId("147c8031-e035-49fa-8fbc-8a99f3fb6846")]
[DisplayName("Foreign Exchange Terms44")]
public record ForeignExchangeTerms44
{
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// </summary>
    [IsoId("158c46a2-abd8-4f7d-8ccb-ecf70b866abf")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required ActiveCurrencyCode UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// </summary>
    [IsoId("cad5cd63-704c-471b-8c9d-205a56e9ce84")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required ActiveCurrencyCode QuotedCurrency { get; init; }

    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another.
    /// </summary>
    [IsoId("610a9bc2-f522-4f6f-95f6-25d53e1fdbab")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("9642e4b5-8c9d-47f5-9a4e-f028d8b731b3")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    [IsoId("26cd587a-a03e-4919-822c-2f568ef8113d")]
    [DisplayName("Quoting Institution")]
    [IsoXmlTag("QtgInstn")]
    public PartyIdentification139? QuotingInstitution { get; init; }
}
