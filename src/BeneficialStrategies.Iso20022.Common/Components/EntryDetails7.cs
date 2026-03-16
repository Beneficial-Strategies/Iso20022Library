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
[IsoId("_VuKI-zqwEeWZFYSPlduMhw")]
[DisplayName("Entry Details")]
public record EntryDetails7
{
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("_V1ya0zqwEeWZFYSPlduMhw")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; }

    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("_V1ya1TqwEeWZFYSPlduMhw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public EntryTransaction8? TransactionDetails { get; init; }
}
