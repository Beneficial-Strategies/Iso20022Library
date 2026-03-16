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
[IsoId("_PWuXEVUIEeetiruPyDPo0Q")]
[DisplayName("Reconciliation Response")]
public record ReconciliationResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_PieUEVUIEeetiruPyDPo0Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment3 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_5ubSEWzoEemD24gVaMSpeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Data pertaining to the reconciliation transaction.
    /// </summary>
    [IsoId("_PieUE1UIEeetiruPyDPo0Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction94 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing.
    /// </summary>
    [IsoId("_W_-LEe_BEeeJbIMlSHFAag")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_iY1ocdXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_bNmocaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
