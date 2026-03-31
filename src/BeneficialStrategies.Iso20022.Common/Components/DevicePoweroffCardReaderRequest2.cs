// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Power-Off Card Reader Request message.
/// </summary>
[IsoId("_ybELUQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Poweroff Card Reader Request")]
public record DevicePoweroffCardReaderRequest2
{
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_ymIL0Q0cEeqUVL7sB4m7NA")]
    [DisplayName("Power Off Maximum Waiting Time")]
    [IsoXmlTag("PwrOffMaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; }

    /// <summary>
    /// Optional message before Power-Off.
    /// </summary>
    [IsoId("_ymIL0w0cEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage7? DisplayOutput { get; init; }
}
