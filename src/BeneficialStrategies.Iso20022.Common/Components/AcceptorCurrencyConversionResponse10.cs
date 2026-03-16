// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion outcome from the service provider.
/// </summary>
[IsoId("_KMVusXJuEe299ZbWCkdR_w")]
[DisplayName("Acceptor Currency Conversion Response")]
public record AcceptorCurrencyConversionResponse10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_KSuDgXJuEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_KSuDg3JuEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction129 Transaction { get; init; }

    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_KSuDhXJuEe299ZbWCkdR_w")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion28 CurrencyConversionResult { get; init; }
}
