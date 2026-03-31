// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the retrieval of a message.
/// </summary>
[IsoId("_rrccsVaDEeeFltjJxERUxw")]
[DisplayName("Retrieval Response")]
public record RetrievalResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_r3MZsVaDEeeFltjJxERUxw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_r3MZs1aDEeeFltjJxERUxw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context4? Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_nuB_oabjEeiva6IOmhpVHw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction89? Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_r3MZuVaDEeeFltjJxERUxw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_zmb84dXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_uHk_IaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
