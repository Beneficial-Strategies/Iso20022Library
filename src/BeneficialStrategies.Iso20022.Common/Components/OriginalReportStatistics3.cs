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
/// Statistical information on the processing of records included in the original report.
/// </summary>
[IsoId("_4h_4QdHEEeaokquJJ-K6uA")]
[DisplayName("Original Report Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalReportStatistics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalReportStatistics3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalReportStatistics3( System.String reqTotalNumberOfRecords )
    {
        TotalNumberOfRecords = reqTotalNumberOfRecords;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total numbers of records included in the original file.
    /// </summary>
    [IsoId("_4rGw8dHEEeaokquJJ-K6uA")]
    [DisplayName("Total Number Of Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRcrds")]
    #endif
    [IsoXmlTag("TtlNbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfRecords { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfRecords { get; init; } 
    #else
    public System.String TotalNumberOfRecords { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of records for each records status.
    /// </summary>
    [IsoId("_4rGw89HEEeaokquJJ-K6uA")]
    [DisplayName("Number Of Records Per Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfRcrdsPerSts")]
    #endif
    [IsoXmlTag("NbOfRcrdsPerSts")]
    public ValueList<NumberOfRecordsPerStatus1> NumberOfRecordsPerStatus { get; init; } = new ValueList<NumberOfRecordsPerStatus1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4rGw89HEEeaokquJJ-K6uA
    
    
    #nullable disable
    
}
