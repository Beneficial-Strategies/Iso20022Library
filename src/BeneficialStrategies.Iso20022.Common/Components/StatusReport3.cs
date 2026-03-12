// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
[IsoId("_J4TeETV9EeODSIIQsYYKhw")]
[DisplayName("Status Report")]
public partial record StatusReport3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_KIhrYTV9EeODSIIQsYYKhw")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification35 POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_KIhrYzV9EeODSIIQsYYKhw")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification35? TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_KIhrZTV9EeODSIIQsYYKhw")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet9> DataSet { get; init; } = new ValueList<TerminalManagementDataSet9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _KIhrZTV9EeODSIIQsYYKhw
    
    
    #nullable disable
    
}
