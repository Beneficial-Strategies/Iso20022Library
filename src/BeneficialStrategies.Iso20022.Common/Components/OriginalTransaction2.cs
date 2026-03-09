// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an original transaction
/// </summary>
[IsoId("_ZTvU4YHREeuwq_rv81SdXw")]
[DisplayName("Original Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_ZY5hsYHREeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Environment20? Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment20? Environment { get; init; } 
    #else
    public Environment20? Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the original message for which a retrieval is being requested.
    /// </summary>
    [IsoId("_ZY5hs4HREeuwq_rv81SdXw")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Context12? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context12? Context { get; init; } 
    #else
    public Context12? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the original transaction details.
    /// </summary>
    [IsoId("_ZY5htYHREeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Transaction147? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction147? Transaction { get; init; } 
    #else
    public Transaction147? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the processing results of the transaction to be retrieved.
    /// </summary>
    [IsoId("_ZY5ht4HREeuwq_rv81SdXw")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingResult10? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult10? ProcessingResult { get; init; } 
    #else
    public ProcessingResult10? ProcessingResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
