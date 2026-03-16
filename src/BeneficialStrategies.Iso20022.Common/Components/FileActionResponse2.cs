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
[IsoId("_gZVqQYKwEeu4svNQ5N-l6w")]
[DisplayName("File Action Response")]
public record FileActionResponse2
{
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [IsoId("_geda0YKwEeu4svNQ5N-l6w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment22 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_geda04KwEeu4svNQ5N-l6w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// File action transaction details.
    /// </summary>
    [IsoId("_geda1YKwEeu4svNQ5N-l6w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction158 Transaction { get; init; }

    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [IsoId("_geda14KwEeu4svNQ5N-l6w")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ResultData9 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_geda2YKwEeu4svNQ5N-l6w")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_geda24KwEeu4svNQ5N-l6w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
