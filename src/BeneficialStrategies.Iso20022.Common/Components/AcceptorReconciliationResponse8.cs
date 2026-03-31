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
[IsoId("_2W61YU7TEeyGi9JAv6wq7Q")]
[DisplayName("Acceptor Reconciliation Response")]
public record AcceptorReconciliationResponse8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_2eCxEU7TEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_2eCxE07TEeyGi9JAv6wq7Q")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType10 TransactionResponse { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_2eCxFU7TEeyGi9JAv6wq7Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation5 Transaction { get; init; }
}
