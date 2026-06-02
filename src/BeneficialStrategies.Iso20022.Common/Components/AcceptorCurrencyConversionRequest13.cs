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
[IsoId("_cyShcbX5EfCUZfsQO4rYeA")]
[DisplayName("Acceptor Currency Conversion Request13")]
public record AcceptorCurrencyConversionRequest13
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_czMgZbX5EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_czMga7X5EfCUZfsQO4rYeA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public PaymentTransaction183? Transaction { get; init; }
}
