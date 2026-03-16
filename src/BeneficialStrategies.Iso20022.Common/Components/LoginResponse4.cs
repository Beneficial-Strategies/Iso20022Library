// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Response message.
/// </summary>
[IsoId("_HNN9wVE9EeyApZmLzm74zA")]
[DisplayName("Login Response")]
public record LoginResponse4
{
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_HTjPQVE9EeyApZmLzm74zA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_HTjPQ1E9EeyApZmLzm74zA")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent12> POISoftware { get; init; } = [];

    // ID for the above is _HTjPQ1E9EeyApZmLzm74zA

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_HTjPRVE9EeyApZmLzm74zA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; }

    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_HTjPR1E9EeyApZmLzm74zA")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage9? OutputDisplay { get; init; }
}
