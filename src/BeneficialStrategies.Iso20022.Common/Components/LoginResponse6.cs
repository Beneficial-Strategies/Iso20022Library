// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Login Response6.
/// </summary>
[IsoId("_lPFGUZFSEe6reqfAp4CunQ")]
[DisplayName("Login Response6")]
public partial record LoginResponse6
{
    #nullable enable

    /// <summary>
    /// Output Display.
    /// </summary>
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage11? OutputDisplay { get; init; } 

    /// <summary>
    /// POI Capabilities.
    /// </summary>
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 

    /// <summary>
    /// POI Date Time.
    /// </summary>
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    public required IsoISODateTime POIDateTime { get; init; } 

    /// <summary>
    /// POI Software.
    /// </summary>
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent15> POISoftware { get; init; } = [];

    
    #nullable disable
    
}
