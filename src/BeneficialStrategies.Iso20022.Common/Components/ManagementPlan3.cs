// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
[IsoId("_XO2EkTWBEeODSIIQsYYKhw")]
[DisplayName("Management Plan")]
public partial record ManagementPlan3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    [IsoId("_XfER4TWBEeODSIIQsYYKhw")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification35? POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_XfER4zWBEeODSIIQsYYKhw")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification35 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_XfER5TWBEeODSIIQsYYKhw")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet10> DataSet { get; init; } = new ValueList<TerminalManagementDataSet10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _XfER5TWBEeODSIIQsYYKhw
    
    
    #nullable disable
    
}
