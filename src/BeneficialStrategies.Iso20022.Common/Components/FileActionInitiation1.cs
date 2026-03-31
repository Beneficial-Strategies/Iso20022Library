// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the file action.
/// </summary>
[IsoId("_d6jqgFEDEee94_dUz-hvgw")]
[DisplayName("File Action Initiation")]
public record FileActionInitiation1
{
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [IsoId("_q8KfoFEDEee94_dUz-hvgw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment3 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_7S_1oWqXEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// File action transaction details.
    /// </summary>
    [IsoId("_qbmeUFEFEee94_dUz-hvgw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction98 Transaction { get; init; }

    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [IsoId("_3HAZ8FEFEee94_dUz-hvgw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ResultData4? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_Y3Fhod0qEeil7LQldntseg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_NX7HgaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
