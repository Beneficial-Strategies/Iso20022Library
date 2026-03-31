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
[IsoId("_cch-sRzwEeK5OKMB21JFBg")]
[DisplayName("Acceptor Reconciliation Response")]
public record AcceptorReconciliationResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_cobssRzwEeK5OKMB21JFBg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment19 Environment { get; init; }

    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_cobstRzwEeK5OKMB21JFBg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_cobsuRzwEeK5OKMB21JFBg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation2 Transaction { get; init; }
}
