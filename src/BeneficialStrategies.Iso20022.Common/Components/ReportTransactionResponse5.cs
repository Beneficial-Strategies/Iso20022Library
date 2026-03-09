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
/// Content of the Transaction Report Response message.
/// </summary>
[IsoId("_tB5KYXJEEe299ZbWCkdR_w")]
[DisplayName("Report Transaction Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportTransactionResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportTransactionResponse5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportTransactionResponse5( System.UInt64 reqReportFullSize,System.UInt64 reqBlockStart,System.UInt64 reqBlockStop )
    {
        ReportFullSize = reqReportFullSize;
        BlockStart = reqBlockStart;
        BlockStop = reqBlockStop;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the total number of transactions matching the search criteria.
    /// </summary>
    [IsoId("_tJNTUXJEEe299ZbWCkdR_w")]
    [DisplayName("Report Full Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptFullSz")]
    #endif
    [IsoXmlTag("RptFullSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber ReportFullSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ReportFullSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ReportFullSize { get; init; } 
    #else
    public System.UInt64 ReportFullSize { get; set; } 
    #endif
    
    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    [IsoId("_tJNTU3JEEe299ZbWCkdR_w")]
    [DisplayName("Block Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckStart")]
    #endif
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber BlockStart { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 BlockStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 BlockStart { get; init; } 
    #else
    public System.UInt64 BlockStart { get; set; } 
    #endif
    
    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    [IsoId("_tJNTVXJEEe299ZbWCkdR_w")]
    [DisplayName("Block Stop")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckStop")]
    #endif
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber BlockStop { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 BlockStop { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 BlockStop { get; init; } 
    #else
    public System.UInt64 BlockStop { get; set; } 
    #endif
    
    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the Search criteria. This list may be partial according to requested block.
    /// </summary>
    [IsoId("_tJNTV3JEEe299ZbWCkdR_w")]
    [DisplayName("Transaction Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRpt")]
    #endif
    [IsoXmlTag("TxRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceResponse7? TransactionReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceResponse7? TransactionReport { get; init; } 
    #else
    public ServiceResponse7? TransactionReport { get; set; } 
    #endif
    
    
    #nullable disable
    
}
