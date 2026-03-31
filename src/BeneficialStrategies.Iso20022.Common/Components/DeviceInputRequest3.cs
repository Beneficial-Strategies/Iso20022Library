// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Input Request message.
/// </summary>
[IsoId("_N15HMS9AEeu125Ip9zFcsQ")]
[DisplayName("Device Input Request")]
public record DeviceInputRequest3
{
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_OC1-ES9AEeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage8? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_OC1-Ey9AEeu125Ip9zFcsQ")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData3 InputData { get; init; }
}
