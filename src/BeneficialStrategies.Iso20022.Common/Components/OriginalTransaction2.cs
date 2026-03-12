// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an original transaction
/// </summary>
[IsoId("_ZTvU4YHREeuwq_rv81SdXw")]
[DisplayName("Original Transaction")]
public partial record OriginalTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_ZY5hsYHREeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public Environment20? Environment { get; init; } 
    
    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_ZY5hs4HREeuwq_rv81SdXw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context12? Context { get; init; } 
    
    /// <summary>
    /// Contains the original transaction details.
    /// </summary>
    [IsoId("_ZY5htYHREeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public Transaction147? Transaction { get; init; } 
    
    /// <summary>
    /// Contains the processing results of the transaction to be retrieved.
    /// </summary>
    [IsoId("_ZY5ht4HREeuwq_rv81SdXw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult10? ProcessingResult { get; init; } 
    
    
    #nullable disable
    
}
