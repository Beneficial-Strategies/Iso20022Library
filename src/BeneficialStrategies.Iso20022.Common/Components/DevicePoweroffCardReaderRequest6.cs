// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Poweroff Card Reader Request6.
/// </summary>
[IsoId("_70w9AZCSEe6zroekBXoFoQ")]
[DisplayName("Device Poweroff Card Reader Request6")]
public record DevicePoweroffCardReaderRequest6
{
    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; }

    /// <summary>
    /// Power Off Maximum Waiting Time.
    /// </summary>
    [DisplayName("Power Off Maximum Waiting Time")]
    [IsoXmlTag("PwrOffMaxWtgTm")]
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; }
}
