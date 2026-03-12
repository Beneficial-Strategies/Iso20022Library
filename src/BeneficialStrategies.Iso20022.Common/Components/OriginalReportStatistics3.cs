// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical information on the processing of records included in the original report.
/// </summary>
[IsoId("_4h_4QdHEEeaokquJJ-K6uA")]
[DisplayName("Original Report Statistics")]
public partial record OriginalReportStatistics3
{
    #nullable enable
    
    /// <summary>
    /// Total numbers of records included in the original file.
    /// </summary>
    [IsoId("_4rGw8dHEEeaokquJJ-K6uA")]
    [DisplayName("Total Number Of Records")]
    [IsoXmlTag("TtlNbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText TotalNumberOfRecords { get; init; } 
    
    /// <summary>
    /// Detailed information on the number of records for each records status.
    /// </summary>
    [IsoId("_4rGw89HEEeaokquJJ-K6uA")]
    [DisplayName("Number Of Records Per Status")]
    [IsoXmlTag("NbOfRcrdsPerSts")]
    public ValueList<NumberOfRecordsPerStatus1> NumberOfRecordsPerStatus { get; init; } = new ValueList<NumberOfRecordsPerStatus1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4rGw89HEEeaokquJJ-K6uA
    
    
    #nullable disable
    
}
