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
/// Information related to the retrieval of a message.
/// </summary>
[IsoId("_o0ZJ4YHSEeuwq_rv81SdXw")]
[DisplayName("Retrieval Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetrievalInitiation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RetrievalInitiation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RetrievalInitiation2( Environment21 reqEnvironment,Context15 reqContext,OriginalTransaction2 reqOriginalTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        OriginalTransaction = reqOriginalTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_o5oPMYHSEeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment21 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment21 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment21 Environment { get; init; } 
    #else
    public Environment21 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_o5oPM4HSEeuwq_rv81SdXw")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context15 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Context15 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context15 Context { get; init; } 
    #else
    public Context15 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    [IsoId("_o5oPNYHSEeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Transaction136? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction136? Transaction { get; init; } 
    #else
    public Transaction136? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_o5oPN4HSEeuwq_rv81SdXw")]
    [DisplayName("Original Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTx")]
    #endif
    [IsoXmlTag("OrgnlTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalTransaction2 OriginalTransaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalTransaction2 OriginalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransaction2 OriginalTransaction { get; init; } 
    #else
    public OriginalTransaction2 OriginalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_o5oPOYHSEeuwq_rv81SdXw")]
    [DisplayName("Protected Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdData")]
    #endif
    [IsoXmlTag("PrtctdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectedData1? ProtectedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectedData1? ProtectedData { get; init; } 
    #else
    public ProtectedData1? ProtectedData { get; set; } 
    #endif
    
    /// <summary>
    /// Destination ID or routing information of Retrieval fulfilment initiation message. 
    /// </summary>
    [IsoId("_o5oPO4HSEeuwq_rv81SdXw")]
    [DisplayName("Retrieval Fulfilment Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrvlFlfmtDstn")]
    #endif
    [IsoXmlTag("RtrvlFlfmtDstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? RetrievalFulfilmentDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? RetrievalFulfilmentDestination { get; init; } 
    #else
    public PartyIdentification258? RetrievalFulfilmentDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_o5oPPYHSEeuwq_rv81SdXw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
