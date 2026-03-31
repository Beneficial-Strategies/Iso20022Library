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
[IsoId("_ifQucU7TEeyGi9JAv6wq7Q")]
[DisplayName("Acceptor Reconciliation Request")]
public record AcceptorReconciliationRequest10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_imuBUU7TEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_imuBU07TEeyGi9JAv6wq7Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation5 Transaction { get; init; }
}
