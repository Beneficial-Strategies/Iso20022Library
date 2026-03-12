// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the status report of a point of interaction (POI).
/// </summary>
[IsoId("_K9WvI31DEeCF8NjrBemJWQ_550700798")]
[DisplayName("Terminal Management Data Set")]
public partial record TerminalManagementDataSet1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_K9WvJH1DEeCF8NjrBemJWQ_1115162778")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification2 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_K9WvJX1DEeCF8NjrBemJWQ_607652482")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_K9WvJn1DEeCF8NjrBemJWQ_1474870666")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent1 Content { get; init; } 
    
    
    #nullable disable
    
}
