// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation request from an acceptor.
/// </summary>
[IsoId("_0goboWl3EeSQMKir9owD5A")]
[DisplayName("Acceptor Cancellation Request")]
public record AcceptorCancellationRequest4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_0vIKoWl3EeSQMKir9owD5A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment35 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_0vIKo2l3EeSQMKir9owD5A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext10 Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_0vIKpWl3EeSQMKir9owD5A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction41 Transaction { get; init; }
}
