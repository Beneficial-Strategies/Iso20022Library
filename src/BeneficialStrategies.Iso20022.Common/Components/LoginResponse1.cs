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
[IsoId("_oud7oN6LEeiwsev40qZGEQ")]
[DisplayName("Login Response")]
public partial record LoginResponse1
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_v7TVwN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_yzUEsN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent9> POISoftware { get; init; } = [];
    // ID for the above is _yzUEsN6LEeiwsev40qZGEQ
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_14FdQN6LEeiwsev40qZGEQ")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities8? POICapabilities { get; init; } 
    
    
    #nullable disable
    
}
