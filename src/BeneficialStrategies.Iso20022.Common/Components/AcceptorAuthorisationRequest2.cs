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
[IsoId("_VXVacQvVEeKzJ69IWwzB9Q")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Vo5EgQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment9 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Vo5EhQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext1 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_Vo5EiQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction11 Transaction { get; init; }
}
