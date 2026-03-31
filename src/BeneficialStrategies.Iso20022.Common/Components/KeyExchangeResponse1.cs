// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a key exchange activity.
/// </summary>
[IsoId("_dnN6lVWfEeeiG_nL4vgKnQ")]
[DisplayName("Key Exchange Response")]
public record KeyExchangeResponse1
{
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_mnCHcWqYEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_dnN6l1WfEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction100 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_dnN6mFWfEeeiG_nL4vgKnQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_YJF28dXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_FNAfEaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
