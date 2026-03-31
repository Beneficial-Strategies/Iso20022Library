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
[IsoId("_djEk4Y3ZEeW56qaqQ8B0kQ")]
[DisplayName("Acceptor Currency Conversion Request")]
public record AcceptorCurrencyConversionRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_duGwMY3ZEeW56qaqQ8B0kQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment56 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_duGwM43ZEeW56qaqQ8B0kQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction64 Transaction { get; init; }
}
