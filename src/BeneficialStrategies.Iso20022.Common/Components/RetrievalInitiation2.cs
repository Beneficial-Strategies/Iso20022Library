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
[IsoId("_o0ZJ4YHSEeuwq_rv81SdXw")]
[DisplayName("Retrieval Initiation")]
public record RetrievalInitiation2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_o5oPMYHSEeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment21 Environment { get; init; }

    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_o5oPM4HSEeuwq_rv81SdXw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context15 Context { get; init; }

    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_o5oPNYHSEeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction136? Transaction { get; init; }

    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_o5oPN4HSEeuwq_rv81SdXw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public required OriginalTransaction2 OriginalTransaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_o5oPOYHSEeuwq_rv81SdXw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Destination ID or routing information of Retrieval fulfilment initiation message.
    /// </summary>
    [IsoId("_o5oPO4HSEeuwq_rv81SdXw")]
    [DisplayName("Retrieval Fulfilment Destination")]
    [IsoXmlTag("RtrvlFlfmtDstn")]
    public PartyIdentification258? RetrievalFulfilmentDestination { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_o5oPPYHSEeuwq_rv81SdXw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
