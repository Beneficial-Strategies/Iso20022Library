// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI, its components and their installed versions.
/// </summary>
[IsoId("_dTvNEQyVEeK5P9Ihqok3VA")]
[DisplayName("Status Report")]
public partial record StatusReport2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_df7O8QyVEeK5P9Ihqok3VA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification35 POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_df7O9QyVEeK5P9Ihqok3VA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification35? TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_df7O-QyVEeK5P9Ihqok3VA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet4> DataSet { get; init; } = new ValueList<TerminalManagementDataSet4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _df7O-QyVEeK5P9Ihqok3VA
    
    
    #nullable disable
    
}
