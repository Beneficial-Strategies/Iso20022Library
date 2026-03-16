// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction(s) and/or batched entries.
/// </summary>
[IsoId("_T_s0cStvEeysar7zFstVmw")]
[DisplayName("Entry Details")]
public record EntryDetails11
{
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("_UWNP8StvEeysar7zFstVmw")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; }

    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("_UWNP8ytvEeysar7zFstVmw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<EntryTransaction12> TransactionDetails { get; init; } = [];
}
