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
[IsoId("_A6GYIQumEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Reconciliation Response")]
public record AcceptorReconciliationResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_BFyqwQumEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_BFyqwwumEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType5 TransactionResponse { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_BFyqxQumEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation4 Transaction { get; init; }
}
