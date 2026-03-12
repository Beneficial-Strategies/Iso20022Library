// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the investigation status as updated in the tracker or investigation facility.
/// </summary>
[IsoId("_CWE9oWHGEe2dtcJPyL3-cw")]
[DisplayName("Tracker Investigation Request")]
public partial record TrackerInvestigationRequest1
{
    #nullable enable
    
    /// <summary>
    /// Type of investigation.
    /// </summary>
    [IsoId("_VDZMsHbgEe2_x8sH-8RFVw")]
    [DisplayName("Investigation Type")]
    [IsoXmlTag("InvstgtnTp")]
    public required InvestigationType2Choice_ InvestigationType { get; init; } 
    
    /// <summary>
    /// Request status and details of assignment by the tracking facility. 
    /// </summary>
    [IsoId("_-hxSgHbiEe2GR4CRzIB77g")]
    [DisplayName("Status And Assignment")]
    [IsoXmlTag("StsAndAssgnmt")]
    public required TrackerInvestigationRequestStatus1 StatusAndAssignment { get; init; } 
    
    /// <summary>
    /// Provides details on the subject to which the investigation refers, for example a payment or statement entry.
    /// </summary>
    [IsoId("_RC5oUXfIEe2A6pitLvwC_g")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public UnderlyingData1Choice_? Underlying { get; init; } 
    
    
    #nullable disable
    
}
