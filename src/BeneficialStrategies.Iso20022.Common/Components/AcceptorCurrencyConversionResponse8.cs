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
[IsoId("_wNrNYS5IEeunNvJlR_vCbg")]
[DisplayName("Acceptor Currency Conversion Response")]
public record AcceptorCurrencyConversionResponse8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_wbN6IS5IEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_wbN6Iy5IEeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction111 Transaction { get; init; }

    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_wbN6JS5IEeunNvJlR_vCbg")]
    [DisplayName("Currency Conversion Result")]
    [IsoXmlTag("CcyConvsRslt")]
    public required CurrencyConversion22 CurrencyConversionResult { get; init; }
}
