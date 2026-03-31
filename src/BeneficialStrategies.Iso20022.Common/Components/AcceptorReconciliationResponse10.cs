// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Reconciliation Response10.
/// </summary>
[IsoId("_7-Lz4ZH0Ee6qwqnYOGEReg")]
[DisplayName("Acceptor Reconciliation Response10")]
public record AcceptorReconciliationResponse10
{
    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation5 Transaction { get; init; }

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType10 TransactionResponse { get; init; }
}
