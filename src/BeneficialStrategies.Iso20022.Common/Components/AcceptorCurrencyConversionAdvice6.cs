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
[IsoId("_ee-b0U4CEey_VecAUE-C9Q")]
[DisplayName("Acceptor Currency Conversion Advice")]
public record AcceptorCurrencyConversionAdvice6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_elKjYU4CEey_VecAUE-C9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and a currency conversion provider.
    /// </summary>
    [IsoId("_elKjY04CEey_VecAUE-C9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction121 Transaction { get; init; }

    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_elKjZU4CEey_VecAUE-C9Q")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public CurrencyConversion24? CurrencyConversionResult { get; init; }
}
