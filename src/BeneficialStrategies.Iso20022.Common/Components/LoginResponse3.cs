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
[IsoId("_XxarES8SEeu125Ip9zFcsQ")]
[DisplayName("Login Response")]
public record LoginResponse3
{
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    [IsoId("_X9MdQS8SEeu125Ip9zFcsQ")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    [IsoId("_X9MdQy8SEeu125Ip9zFcsQ")]
    [DisplayName("POI Software")]
    [IsoXmlTag("POISftwr")]
    public ValueList<PointOfInteractionComponent11> POISoftware { get; init; } = [];

    // ID for the above is _X9MdQy8SEeu125Ip9zFcsQ

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_X9MdRS8SEeu125Ip9zFcsQ")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; }

    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_X9MdRy8SEeu125Ip9zFcsQ")]
    [DisplayName("Output Display")]
    [IsoXmlTag("OutptDisp")]
    public ActionMessage8? OutputDisplay { get; init; }
}
