// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the login response message.
/// </summary>
[IsoId("_BjNAYXJHEe299ZbWCkdR_w")]
[DisplayName("Login Response")]
public partial record LoginResponse5
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_BqSf0XJHEe299ZbWCkdR_w")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_BqSf03JHEe299ZbWCkdR_w")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent14> POISoftware { get; init; } = new ValueList<PointOfInteractionComponent14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BqSf03JHEe299ZbWCkdR_w
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_BqSf1XJHEe299ZbWCkdR_w")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_BqSf13JHEe299ZbWCkdR_w")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage10? OutputDisplay { get; init; } 
    
    
    #nullable disable
    
}
