// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Input Request6.
/// </summary>
[IsoId("_zsWg4ZCREe6zroekBXoFoQ")]
[DisplayName("Device Input Request6")]
public record DeviceInputRequest6
{
    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; }

    /// <summary>
    /// Input Data.
    /// </summary>
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData6 InputData { get; init; }
}
