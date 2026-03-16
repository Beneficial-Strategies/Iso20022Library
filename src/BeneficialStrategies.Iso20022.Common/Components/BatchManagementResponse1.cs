// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a batch management initiation message.
/// </summary>
[IsoId("_kmF6AFA1EeedyPuM0kK2EQ")]
[DisplayName("Batch Management Response")]
public record BatchManagementResponse1
{
    /// <summary>
    /// Environment of the batch management transaction.
    /// </summary>
    [IsoId("_y20NoFA1EeedyPuM0kK2EQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment3 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_UPjfAWqGEemXfKijhrqa-Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Details about the batch management transaction.
    /// </summary>
    [IsoId("_--E6YFA1EeedyPuM0kK2EQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction95 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing.
    /// </summary>
    [IsoId("_7zVAMFA2EeedyPuM0kK2EQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult3 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_067VgdXvEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_dXAP0aK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
