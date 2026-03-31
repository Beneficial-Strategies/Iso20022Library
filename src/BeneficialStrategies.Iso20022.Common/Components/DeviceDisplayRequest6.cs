// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Display Request6.
/// </summary>
[IsoId("_uhWjAZCOEe6zroekBXoFoQ")]
[DisplayName("Device Display Request6")]
public record DeviceDisplayRequest6
{
    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage11> DisplayOutput { get; init; } = [];
}
