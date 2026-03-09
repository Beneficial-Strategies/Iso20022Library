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
/// Information related to the chargeback response transaction.
/// </summary>
[IsoId("_RVofAVZhEeen1vB4iz5SyA")]
[DisplayName("Charge Back Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChargeBackResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChargeBackResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChargeBackResponse1( Environment14 reqEnvironment,Context9 reqContext,Transaction97 reqTransaction,ProcessingResult7 reqProcessingResult )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
        ProcessingResult = reqProcessingResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the chargeback.
    /// </summary>
    [IsoId("_Rh-48VZhEeen1vB4iz5SyA")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment14 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment14 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment14 Environment { get; init; } 
    #else
    public Environment14 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the chargeback transaction.
    /// </summary>
    [IsoId("_Rh-481ZhEeen1vB4iz5SyA")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Context9 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Context9 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context9 Context { get; init; } 
    #else
    public Context9 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Chargeback transaction details.
    /// </summary>
    [IsoId("_Rh-49VZhEeen1vB4iz5SyA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction97 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction97 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction97 Transaction { get; init; } 
    #else
    public Transaction97 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the chargeback verification provided in the chargeback status.
    /// </summary>
    [IsoId("_Rh-491ZhEeen1vB4iz5SyA")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingResult7 ProcessingResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingResult7 ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult7 ProcessingResult { get; init; } 
    #else
    public ProcessingResult7 ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_YAr-UdXwEee5XtaG1wqDfQ")]
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
    [IsoId("_-fU7kaK4EeeQobSgLcPRvA")]
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
