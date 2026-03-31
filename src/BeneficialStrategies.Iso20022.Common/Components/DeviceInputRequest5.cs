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
[IsoId("_OzUpUXGcEe2TbaNWBpRZpQ")]
[DisplayName("Device Input Request")]
public record DeviceInputRequest5
{
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_O5oFoXGcEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage10? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_O5oFo3GcEe2TbaNWBpRZpQ")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData5 InputData { get; init; }
}
