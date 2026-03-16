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
[IsoId("_erzXAYHXEeu7P-fjMhpKOg")]
[DisplayName("Retrieval Response")]
public record RetrievalResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_exOpkYHXEeu7P-fjMhpKOg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment21 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_exOpk4HXEeu7P-fjMhpKOg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context15? Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_exOplYHXEeu7P-fjMhpKOg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction136? Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_exOpl4HXEeu7P-fjMhpKOg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult19 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_exPQoYHXEeu7P-fjMhpKOg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_exPQo4HXEeu7P-fjMhpKOg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
