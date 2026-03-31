// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion request.
/// </summary>
[IsoId("_uPKTIaqLEeanIZ10Ka8PnA")]
[DisplayName("Acceptor Currency Conversion Request")]
public record AcceptorCurrencyConversionRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_uaNskaqLEeanIZ10Ka8PnA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment63 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_uaNsk6qLEeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction72 Transaction { get; init; }
}
