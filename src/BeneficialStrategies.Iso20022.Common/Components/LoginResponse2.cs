// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Response message.
/// </summary>
[IsoId("_hshvcQ0yEeqUVL7sB4m7NA")]
[DisplayName("Login Response")]
public partial record LoginResponse2
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_h4V94Q0yEeqUVL7sB4m7NA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_h4V94w0yEeqUVL7sB4m7NA")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent10> POISoftware { get; init; } = [];
    // ID for the above is _h4V94w0yEeqUVL7sB4m7NA
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_h4V95Q0yEeqUVL7sB4m7NA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_utBKQQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage7? OutputDisplay { get; init; } 
    
    
    #nullable disable
    
}
