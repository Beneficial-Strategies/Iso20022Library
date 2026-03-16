// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about inactivity of a system.
/// </summary>
[IsoId("_xkRfK5lcEeeE1Ya-LgRsuQ")]
[DisplayName("System Closure")]
public record SystemClosure2
{
    /// <summary>
    /// Period of time when the system is closed/not operating.
    /// </summary>
    [IsoId("_xs2zY5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DateTimePeriod1Choice_? Period { get; init; }

    /// <summary>
    /// Reason the system is closed/not operating.
    /// </summary>
    [IsoId("_xs2zZZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ClosureReason2Choice_ Reason { get; init; }
}
