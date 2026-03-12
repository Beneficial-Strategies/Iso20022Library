// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_4rGw9dHEEeaokquJJ-K6uA")]
[DisplayName("Number Of Records Per Status")]
public partial record NumberOfRecordsPerStatus1
{
    #nullable enable
    
    /// <summary>
    /// Number of individual records contained in the message, detailed per status.
    /// </summary>
    [IsoId("_40TJMdHEEeaokquJJ-K6uA")]
    [DisplayName("Detailed Number Of Records")]
    [IsoXmlTag("DtldNbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfRecords { get; init; } 
    
    /// <summary>
    /// Common transaction status for all individual records reported.
    /// </summary>
    [IsoId("_40TJM9HEEeaokquJJ-K6uA")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required ReportingRecordStatus1Code DetailedStatus { get; init; } 
    
    
    #nullable disable
    
}
