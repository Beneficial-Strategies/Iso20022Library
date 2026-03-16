// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation response message.
/// </summary>
[IsoId("_Y5jikYv-EeuC5632vxUfGg")]
[DisplayName("Reconciliation Response")]
public record ReconciliationResponse7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Y-RqgYv-EeuC5632vxUfGg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment33 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Y-Rqg4v-EeuC5632vxUfGg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Data pertaining to the reconciliation transaction.
    /// </summary>
    [IsoId("_Y-RqhYv-EeuC5632vxUfGg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction135 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing.
    /// </summary>
    [IsoId("_Y-Rqh4v-EeuC5632vxUfGg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult19 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_Y-RqiYv-EeuC5632vxUfGg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Y-Rqi4v-EeuC5632vxUfGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
