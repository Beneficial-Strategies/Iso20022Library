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
[IsoId("_0g4ZQdqOEeearpaEPXv9UA")]
[DisplayName("Terminal Management Data Set")]
public partial record TerminalManagementDataSet26
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_0qUpIdqOEeearpaEPXv9UA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification7 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_0qUpI9qOEeearpaEPXv9UA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_0qUpJdqOEeearpaEPXv9UA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent7 Content { get; init; } 
    
    
    #nullable disable
    
}
