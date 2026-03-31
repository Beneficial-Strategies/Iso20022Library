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
[IsoId("_McZxwU4DEey_VecAUE-C9Q")]
[DisplayName("Acceptor Currency Conversion Response")]
public record AcceptorCurrencyConversionResponse9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_MitOEU4DEey_VecAUE-C9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_MitOE04DEey_VecAUE-C9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction121 Transaction { get; init; }

    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_MitOFU4DEey_VecAUE-C9Q")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion25 CurrencyConversionResult { get; init; }
}
