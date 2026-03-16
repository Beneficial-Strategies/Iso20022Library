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
[IsoId("_7nhvUYKvEeu4svNQ5N-l6w")]
[DisplayName("File Action Initiation")]
public record FileActionInitiation2
{
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [IsoId("_7sqG8YKvEeu4svNQ5N-l6w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment22 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_7sqG84KvEeu4svNQ5N-l6w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// File action transaction details.
    /// </summary>
    [IsoId("_7sqG9YKvEeu4svNQ5N-l6w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction157 Transaction { get; init; }

    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [IsoId("_7sqG94KvEeu4svNQ5N-l6w")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ResultData9? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_7sqG-YKvEeu4svNQ5N-l6w")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_7sqG-4KvEeu4svNQ5N-l6w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
