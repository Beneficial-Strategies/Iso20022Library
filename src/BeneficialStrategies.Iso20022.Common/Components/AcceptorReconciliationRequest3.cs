// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation request from an acceptor.
/// </summary>
[IsoId("_9Grl8TJsEeOQDoPKFK41HQ")]
[DisplayName("Acceptor Reconciliation Request")]
public record AcceptorReconciliationRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_9WAbYTJsEeOQDoPKFK41HQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment25 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_9WAbYzJsEeOQDoPKFK41HQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation2 Transaction { get; init; }
}
