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
/// Provides the details of the header for a trade transaction query message.
/// </summary>
[IsoId("_7oH-8cWBEeijrI2SDYOAOw")]
[DisplayName("Trade Query Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeQueryHeader4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeQueryHeader4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeQueryHeader4( Pagination1 reqMessagePagination,System.UInt64 reqNumberRecords )
    {
        MessagePagination = reqMessagePagination;
        NumberRecords = reqNumberRecords;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the day that the query was executed.
    /// </summary>
    [IsoId("_70_WQcWBEeijrI2SDYOAOw")]
    [DisplayName("Query Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryExctnDt")]
    #endif
    [IsoXmlTag("QryExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? QueryExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? QueryExecutionDate { get; init; } 
    #else
    public System.DateOnly? QueryExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_71JHQcWBEeijrI2SDYOAOw")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 MessagePagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 MessagePagination { get; init; } 
    #else
    public Pagination1 MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the number of records in the page.
    /// </summary>
    [IsoId("_71JHQ8WBEeijrI2SDYOAOw")]
    [DisplayName("Number Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbRcrds")]
    #endif
    [IsoXmlTag("NbRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberRecords { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberRecords { get; init; } 
    #else
    public System.UInt64 NumberRecords { get; set; } 
    #endif
    
    
    #nullable disable
    
}
