// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a POI component (Point of Interaction).
/// </summary>
[IsoId("_y3Kq4WiwEeS87LmvcA55sg")]
[DisplayName("Point Of Interaction Component Status")]
public partial record PointOfInteractionComponentStatus2
{
    #nullable enable
    
    /// <summary>
    /// Current version of the component that might include the release number.
    /// </summary>
    [IsoId("_zEWLQWiwEeS87LmvcA55sg")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? VersionNumber { get; init; } 
    
    /// <summary>
    /// Current status of the component.
    /// </summary>
    [IsoId("_zEWLQ2iwEeS87LmvcA55sg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public POIComponentStatus1Code? Status { get; init; } 
    
    
    #nullable disable
    
}
