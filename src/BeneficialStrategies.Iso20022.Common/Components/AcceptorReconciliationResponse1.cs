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
[IsoId("_Svfw-wEcEeCQm6a_G2yO_w_828551474")]
[DisplayName("Acceptor Reconciliation Response")]
public record AcceptorReconciliationResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Svfw_AEcEeCQm6a_G2yO_w_766279755")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment7 Environment { get; init; }

    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_Svfw_QEcEeCQm6a_G2yO_w_-1242316409")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_Svfw_gEcEeCQm6a_G2yO_w_-712189637")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation1 Transaction { get; init; }
}
