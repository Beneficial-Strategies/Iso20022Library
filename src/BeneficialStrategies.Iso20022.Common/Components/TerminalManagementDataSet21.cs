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
[IsoId("_CkkxwbCaEeapjPTKZHuM2w")]
[DisplayName("Terminal Management Data Set")]
public partial record TerminalManagementDataSet21
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_Cw5WgbCaEeapjPTKZHuM2w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification6 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_Cw5Wg7CaEeapjPTKZHuM2w")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_Cw5WhbCaEeapjPTKZHuM2w")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent6 Content { get; init; } 
    
    
    #nullable disable
    
}
