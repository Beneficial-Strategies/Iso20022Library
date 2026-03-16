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
[IsoId("_Svyr5wEcEeCQm6a_G2yO_w_350804909")]
[DisplayName("Acceptor Cancellation Request")]
public record AcceptorCancellationRequest1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Svyr6AEcEeCQm6a_G2yO_w_1164620738")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment4 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Svyr6QEcEeCQm6a_G2yO_w_1925385891")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext1 Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_Svyr6gEcEeCQm6a_G2yO_w_-885061607")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction5 Transaction { get; init; }
}
