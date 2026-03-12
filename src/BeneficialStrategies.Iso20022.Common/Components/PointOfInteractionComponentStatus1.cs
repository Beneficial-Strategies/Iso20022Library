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
[IsoId("_e-Tb0AxxEeKa_56Jbsi1RQ")]
[DisplayName("Point Of Interaction Component Status")]
public partial record PointOfInteractionComponentStatus1
{
    #nullable enable
    
    /// <summary>
    /// Current version of the component that might include the release number.
    /// </summary>
    [IsoId("_4ybhMAxxEeKa_56Jbsi1RQ")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VersionNumber { get; init; } 
    
    /// <summary>
    /// Current status of the component.
    /// </summary>
    [IsoId("__SswQAxxEeKa_56Jbsi1RQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public POIComponentStatus1Code? Status { get; init; } 
    
    
    #nullable disable
    
}
