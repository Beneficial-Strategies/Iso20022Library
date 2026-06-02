// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the display request message.
/// </summary>
[IsoId("_uXqBwbZeEfCUZfsQO4rYeA")]
[DisplayName("Device Display Request7")]
public record DeviceDisplayRequest7
{
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_uYiylbZeEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    [MinLength(1)]
    public ValueList<ActionMessage12> DisplayOutput { get; init; } = [];
}
