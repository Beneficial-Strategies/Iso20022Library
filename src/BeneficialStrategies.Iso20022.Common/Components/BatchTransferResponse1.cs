// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a batch transfer initiation message.
/// </summary>
[IsoId("_ga-X4FBKEeedyPuM0kK2EQ")]
[DisplayName("Batch Transfer Response")]
public record BatchTransferResponse1
{
    /// <summary>
    /// Environment of the message.
    /// </summary>
    [IsoId("_vu-GYFBKEeedyPuM0kK2EQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment4 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_2UX_gWqXEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Batch transfer transaction.
    /// </summary>
    [IsoId("_lIqZkFBLEeedyPuM0kK2EQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction96 Transaction { get; init; }

    /// <summary>
    /// Outcome of processing.
    /// </summary>
    [IsoId("_0YcWYe_AEeeJbIMlSHFAag")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult3 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_AjUU8dXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_n6utQaK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
