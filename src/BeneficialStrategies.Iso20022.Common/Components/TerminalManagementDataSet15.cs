// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the management plan of a point of interaction (POI).
/// </summary>
[IsoId("_QmvQAWpPEeSR-ZWLvO-1dg")]
[DisplayName("Terminal Management Data Set")]
public partial record TerminalManagementDataSet15
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_QzZzAWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification4 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_QzZzA2pPEeSR-ZWLvO-1dg")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_QzZzBWpPEeSR-ZWLvO-1dg")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent4? Content { get; init; } 
    
    
    #nullable disable
    
}
