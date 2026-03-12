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
[IsoId("_DSOZQY0TEeWRYffwL7E13A")]
[DisplayName("Point Of Interaction Component Status")]
public partial record PointOfInteractionComponentStatus3
{
    #nullable enable
    
    /// <summary>
    /// Current version of the component that might include the release number.
    /// </summary>
    [IsoId("_DcqHoY0TEeWRYffwL7E13A")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? VersionNumber { get; init; } 
    
    /// <summary>
    /// Current status of the component.
    /// </summary>
    [IsoId("_DcqHo40TEeWRYffwL7E13A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public POIComponentStatus1Code? Status { get; init; } 
    
    /// <summary>
    /// Expiration date of the component.
    /// </summary>
    [IsoId("_MHmegI0TEeWRYffwL7E13A")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; } 
    
    
    #nullable disable
    
}
