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
[IsoId("_GtcD0DTpEeOLr8wG_Q16kw")]
[DisplayName("Acceptor Currency Conversion Request")]
public record AcceptorCurrencyConversionRequest1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_REq9YDTpEeOLr8wG_Q16kw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment30 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_XXtBsDTpEeOLr8wG_Q16kw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction34 Transaction { get; init; }
}
