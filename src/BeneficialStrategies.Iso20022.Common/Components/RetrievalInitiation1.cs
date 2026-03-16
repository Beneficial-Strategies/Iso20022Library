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
[IsoId("_L_0MsVZoEeeFltjJxERUxw")]
[DisplayName("Retrieval Initiation")]
public record RetrievalInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_MLROwVZoEeeFltjJxERUxw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_xigyAFZoEeeFltjJxERUxw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context4 Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_MLROw1ZoEeeFltjJxERUxw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction89? Transaction { get; init; }

    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_JXDEQKZNEeiva6IOmhpVHw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public required OriginalTransaction1 OriginalTransaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_uZvOgdXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Destination ID or routing information of Retrieval fulfilment initiation message.
    /// </summary>
    [IsoId("_jLNxUOwnEeiMkKo2clXHdQ")]
    [DisplayName("Retrieval Fulfilment Destination")]
    [IsoXmlTag("RtrvlFlfmtDstn")]
    public PartyIdentification197? RetrievalFulfilmentDestination { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_l175EaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
