// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation request from an acceptor.
/// </summary>
[IsoId("_SwFm0QEcEeCQm6a_G2yO_w_-200093318")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_SwFm0gEcEeCQm6a_G2yO_w_-1079461423")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment1 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_SwFm0wEcEeCQm6a_G2yO_w_-1736610459")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext1 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_SwFm1AEcEeCQm6a_G2yO_w_45281019")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction1 Transaction { get; init; }
}
