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
[IsoId("_uopQUWpCEeS4VPLpYyQgxQ")]
[DisplayName("Acceptor Currency Conversion Request")]
public record AcceptorCurrencyConversionRequest2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_u1A4YWpCEeS4VPLpYyQgxQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment44 Environment { get; init; }

    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    [IsoId("_u1A4Y2pCEeS4VPLpYyQgxQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction49 Transaction { get; init; }
}
