// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
[IsoId("_BdxRYWmBEeSxgrJ0GX4SQQ")]
[DisplayName("Acceptor Reconciliation Response")]
public record AcceptorReconciliationResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_BrFUoWmBEeSxgrJ0GX4SQQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment38 Environment { get; init; }

    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_BrFUo2mBEeSxgrJ0GX4SQQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_BrFUpWmBEeSxgrJ0GX4SQQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation3 Transaction { get; init; }
}
