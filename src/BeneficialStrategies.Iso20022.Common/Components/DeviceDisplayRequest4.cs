// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Display Request message.
/// </summary>
[IsoId("_IimjsVE6EeyApZmLzm74zA")]
[DisplayName("Device Display Request")]
public record DeviceDisplayRequest4
{
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_IpU2wVE6EeyApZmLzm74zA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage9> DisplayOutput { get; init; } = [];
    // ID for the above is _IpU2wVE6EeyApZmLzm74zA
}
