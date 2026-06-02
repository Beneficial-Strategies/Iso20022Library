// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the input request message.
/// </summary>
[IsoId("_3UPiQbZeEfCUZfsQO4rYeA")]
[DisplayName("Device Input Request7")]
public record DeviceInputRequest7
{
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_3VHE9bZeEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_3VHE-7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData7 InputData { get; init; }
}
