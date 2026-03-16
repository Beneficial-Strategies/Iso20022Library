// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Login Response7.
/// </summary>
[IsoId("_lME9EZ-KEe-nbM0aSPcoiQ")]
[DisplayName("Login Response7")]
public record LoginResponse7
{
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
    public ValueList<PointOfInteractionComponent17> POISoftware { get; init; } = [];
}
