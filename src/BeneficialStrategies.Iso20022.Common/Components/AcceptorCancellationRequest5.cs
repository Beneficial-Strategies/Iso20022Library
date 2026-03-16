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
[IsoId("_7fP2QY1AEeWsypzzYao74A")]
[DisplayName("Acceptor Cancellation Request")]
public record AcceptorCancellationRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_7rneUY1AEeWsypzzYao74A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment48 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_7rneU41AEeWsypzzYao74A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext16 Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_7rneVY1AEeWsypzzYao74A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction56 Transaction { get; init; }
}
