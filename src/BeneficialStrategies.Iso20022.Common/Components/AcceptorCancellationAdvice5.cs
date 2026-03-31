// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation transaction between an acceptor and an acquirer.
/// </summary>
[IsoId("_12mZcY1FEeWsypzzYao74A")]
[DisplayName("Acceptor Cancellation Advice")]
public record AcceptorCancellationAdvice5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_2A4W0Y1FEeWsypzzYao74A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment49 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_2A4W041FEeWsypzzYao74A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext17? Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_2A4W1Y1FEeWsypzzYao74A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction59 Transaction { get; init; }
}
