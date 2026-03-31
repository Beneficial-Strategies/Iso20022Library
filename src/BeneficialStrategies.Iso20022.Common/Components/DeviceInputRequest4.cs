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
[IsoId("__vrgEVE6EeyApZmLzm74zA")]
[DisplayName("Device Input Request")]
public record DeviceInputRequest4
{
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("__1-VUVE6EeyApZmLzm74zA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage9? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("__1-VU1E6EeyApZmLzm74zA")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData4 InputData { get; init; }
}
