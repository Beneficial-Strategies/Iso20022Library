// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the fulfilment of a retrieval.
/// </summary>
[IsoId("_avsgEYHSEeuwq_rv81SdXw")]
[DisplayName("Retrieval Fulfilment Initiation")]
public partial record RetrievalFulfilmentInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_a1F9cYHSEeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment21 Environment { get; init; } 
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_a1F9c4HSEeuwq_rv81SdXw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context15 Context { get; init; } 
    
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_a1F9dYHSEeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction136? Transaction { get; init; } 
    
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_a1F9d4HSEeuwq_rv81SdXw")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public OriginalTransaction2? OriginalTransaction { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_a1F9eYHSEeuwq_rv81SdXw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_a1F9e4HSEeuwq_rv81SdXw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
