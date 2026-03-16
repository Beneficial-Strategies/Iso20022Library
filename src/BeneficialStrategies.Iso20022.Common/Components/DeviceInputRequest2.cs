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
[IsoId("_hExN4Q0cEeqUVL7sB4m7NA")]
[DisplayName("Device Input Request")]
public record DeviceInputRequest2
{
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_hPwV4Q0cEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage7? DisplayOutput { get; init; }

    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_hPwV4w0cEeqUVL7sB4m7NA")]
    [DisplayName("Input Data")]
    [IsoXmlTag("InptData")]
    public required InputData2 InputData { get; init; }
}
