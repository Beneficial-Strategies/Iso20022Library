// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a RetrievalFulfillmentInitiation message.
/// </summary>
[IsoId("_dZfqYeFGEeeRS5LRvWPKMw")]
[DisplayName("Retrieval Fullfilment Response")]
public record RetrievalFullfilmentResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_dliiUeFGEeeRS5LRvWPKMw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_dliiU-FGEeeRS5LRvWPKMw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context4 Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_LLnEkfMtEei4qfiLgRIZBA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction89? Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_dliiXeFGEeeRS5LRvWPKMw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_dliiYeFGEeeRS5LRvWPKMw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_dliiY-FGEeeRS5LRvWPKMw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
