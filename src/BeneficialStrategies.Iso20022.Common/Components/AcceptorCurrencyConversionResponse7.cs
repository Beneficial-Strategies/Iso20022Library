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
[IsoId("_--bdAQuiEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Currency Conversion Response")]
public record AcceptorCurrencyConversionResponse7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("__Jp1kQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("__Jp1kwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction93 Transaction { get; init; }

    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("__Jp1lQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion18 CurrencyConversionResult { get; init; }
}
