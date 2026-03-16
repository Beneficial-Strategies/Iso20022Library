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
[IsoId("_1yxoYdwiEeeKpa-yxjuKzQ")]
[DisplayName("Acceptor Reconciliation Request")]
public record AcceptorReconciliationRequest7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_17rswdwiEeeKpa-yxjuKzQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_17rsw9wiEeeKpa-yxjuKzQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionReconciliation4 Transaction { get; init; }
}
