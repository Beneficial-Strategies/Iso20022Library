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
/// Information related to the verification initiation message.
/// </summary>
[IsoId("_TVdDwVf4EeedJb6VxsnkPg")]
[DisplayName("Verification Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VerificationInitiation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VerificationInitiation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VerificationInitiation1( Environment1 reqEnvironment,Context5 reqContext,Transaction83 reqTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_TgnK4Vf4EeedJb6VxsnkPg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment1 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment1 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment1 Environment { get; init; } 
    #else
    public Environment1 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_TgnK41f4EeedJb6VxsnkPg")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context5 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Context5 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context5 Context { get; init; } 
    #else
    public Context5 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_TgnK5Vf4EeedJb6VxsnkPg")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction83 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction83 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction83 Transaction { get; init; } 
    #else
    public Transaction83 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    [IsoId("_TgnK51f4EeedJb6VxsnkPg")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingResult6? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult6? ProcessingResult { get; init; } 
    #else
    public ProcessingResult6? ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_TgnK6Vf4EeedJb6VxsnkPg")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ICCRelatedData { get; init; } 
    #else
    public System.String? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_ijrG0dXuEee5XtaG1wqDfQ")]
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
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_kehvUaK8EeeQobSgLcPRvA")]
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
