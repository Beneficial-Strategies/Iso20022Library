// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies what to do during shutdown.
/// </summary>
[IsoId("_ZF4QwbZfEfCUZfsQO4rYeA")]
[DisplayName("Device Poweroff Card Reader Request7")]
public record DevicePoweroffCardReaderRequest7
{
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_ZGzd1bZfEfCUZfsQO4rYeA")]
    [DisplayName("Power Off Maximum Waiting Time")]
    [IsoXmlTag("PwrOffMaxWtgTm")]
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; }

    /// <summary>
    /// Optional message before Power-Off.
    /// </summary>
    [IsoId("_ZGzd27ZfEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }
}
