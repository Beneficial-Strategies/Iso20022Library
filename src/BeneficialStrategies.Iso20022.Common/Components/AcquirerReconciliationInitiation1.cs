// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation.
/// </summary>
[IsoId("_ynYVIHu5EeSLmfFG0DG7zQ")]
[DisplayName("Acquirer Reconciliation Initiation")]
public record AcquirerReconciliationInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NQvZYHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment5 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction.
    /// </summary>
    [IsoId("_9ATbUHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction9 Transaction { get; init; }
}
