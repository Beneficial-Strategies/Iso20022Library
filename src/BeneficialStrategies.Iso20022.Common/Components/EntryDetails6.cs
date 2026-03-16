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
[IsoId("_byl1Ox77EeSxevWRRWxNAg")]
[DisplayName("Entry Details")]
public record EntryDetails6
{
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("_cDkQUx77EeSxevWRRWxNAg")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; }

    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("_cDkQVR77EeSxevWRRWxNAg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public EntryTransaction7? TransactionDetails { get; init; }
}
