// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to network management services.
/// </summary>
[IsoId("_hhfqsVWSEeeiG_nL4vgKnQ")]
[DisplayName("Network Management Initiation")]
public record NetworkManagementInitiation1
{
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_o7wjIWqYEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Details of an exchange or interaction between parties to perform a specific function.
    /// </summary>
    [IsoId("_hs9T01WSEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction99 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_hs9T1VWSEeeiG_nL4vgKnQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult1? ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_MGuI4aK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
