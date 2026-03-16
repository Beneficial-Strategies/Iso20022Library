// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a reconciliation.
/// </summary>
[IsoId("_R8Nl0HvBEeSLmfFG0DG7zQ")]
[DisplayName("Acquirer Reconciliation Response")]
public record AcquirerReconciliationResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_nmFRQHvBEeSLmfFG0DG7zQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment5 Environment { get; init; }

    /// <summary>
    /// Reconciliation transaction.
    /// </summary>
    [IsoId("_KpkCIHvCEeSLmfFG0DG7zQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction10 Transaction { get; init; }
}
