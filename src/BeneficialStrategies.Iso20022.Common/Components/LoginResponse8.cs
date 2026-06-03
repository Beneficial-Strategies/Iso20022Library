// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the login response message.
/// </summary>
[IsoId("_ubBUQbZdEfCUZfsQO4rYeA")]
[DisplayName("Login Response8")]
public record LoginResponse8
{
    /// <summary>
    /// Date and time of POI login.
    /// </summary>
    [IsoId("_ub7TNbZdEfCUZfsQO4rYeA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_ub7TO7ZdEfCUZfsQO4rYeA")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    [MinLength(1)]
    public ValueList<PointOfInteractionComponent18> POISoftware { get; init; } = [];

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_ub7TQbZdEfCUZfsQO4rYeA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; }

    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_ub7TR7ZdEfCUZfsQO4rYeA")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage12? OutputDisplay { get; init; }
}
