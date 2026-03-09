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
/// Provides detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_4rGw9dHEEeaokquJJ-K6uA")]
[DisplayName("Number Of Records Per Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfRecordsPerStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfRecordsPerStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfRecordsPerStatus1( System.String reqDetailedNumberOfRecords,ReportingRecordStatus1Code reqDetailedStatus )
    {
        DetailedNumberOfRecords = reqDetailedNumberOfRecords;
        DetailedStatus = reqDetailedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual records contained in the message, detailed per status.
    /// </summary>
    [IsoId("_40TJMdHEEeaokquJJ-K6uA")]
    [DisplayName("Detailed Number Of Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldNbOfRcrds")]
    #endif
    [IsoXmlTag("DtldNbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumberOfRecords { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DetailedNumberOfRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumberOfRecords { get; init; } 
    #else
    public System.String DetailedNumberOfRecords { get; set; } 
    #endif
    
    /// <summary>
    /// Common transaction status for all individual records reported.
    /// </summary>
    [IsoId("_40TJM9HEEeaokquJJ-K6uA")]
    [DisplayName("Detailed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldSts")]
    #endif
    [IsoXmlTag("DtldSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingRecordStatus1Code DetailedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingRecordStatus1Code DetailedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingRecordStatus1Code DetailedStatus { get; init; } 
    #else
    public ReportingRecordStatus1Code DetailedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
