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
[IsoId("_VbXWcXJvEe299ZbWCkdR_w")]
[DisplayName("Acceptor Currency Conversion Advice")]
public record AcceptorCurrencyConversionAdvice7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_VhyHgXJvEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and a currency conversion provider.
    /// </summary>
    [IsoId("_VhyHg3JvEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction129 Transaction { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_VhyHhXJvEe299ZbWCkdR_w")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion27? CurrencyConversionResult { get; init; }
}
