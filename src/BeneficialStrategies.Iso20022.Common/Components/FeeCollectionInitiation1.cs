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
/// Information related to a fee collection initiation message.
/// </summary>
[IsoId("_ZhYGsVaIEeeFltjJxERUxw")]
[DisplayName("Fee Collection Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FeeCollectionInitiation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FeeCollectionInitiation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FeeCollectionInitiation1( Environment5 reqEnvironment,Transaction103 reqTransaction )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ZtIDsVaIEeeFltjJxERUxw")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment5 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment5 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment5 Environment { get; init; } 
    #else
    public Environment5 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_oCUAYc5dEeiEmaZryQQ14Q")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Context9? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context9? Context { get; init; } 
    #else
    public Context9? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_ZtIDtVaIEeeFltjJxERUxw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction103 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction103 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction103 Transaction { get; init; } 
    #else
    public Transaction103 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_ZtIDt1aIEeeFltjJxERUxw")]
    [DisplayName("Processing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgRslt")]
    #endif
    [IsoXmlTag("PrcgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingResult4? ProcessingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingResult4? ProcessingResult { get; init; } 
    #else
    public ProcessingResult4? ProcessingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_dMLy0dXwEee5XtaG1wqDfQ")]
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
    [IsoId("_EVMiwaK5EeeQobSgLcPRvA")]
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
