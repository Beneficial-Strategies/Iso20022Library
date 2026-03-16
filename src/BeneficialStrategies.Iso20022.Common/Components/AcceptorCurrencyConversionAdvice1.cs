// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion advice.
/// </summary>
[IsoId("_I3RMACAxEeeqBb2eaJB13A")]
[DisplayName("Acceptor Currency Conversion Advice")]
public record AcceptorCurrencyConversionAdvice1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YMozgCAxEeeqBb2eaJB13A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment65 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and a currency conversion provider.
    /// </summary>
    [IsoId("_gw4FcSAxEeeqBb2eaJB13A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction77 Transaction { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_16m4QSAxEeeqBb2eaJB13A")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion13? CurrencyConversionResult { get; init; }
}
