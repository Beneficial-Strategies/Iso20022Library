// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement from an ATM to contact the ATM manager.
/// </summary>
[IsoId("_8rvoQItrEeSDLd7nI4Quzw")]
[DisplayName("Host To ATM Acknowledgement")]
public record HostToATMAcknowledgement1
{
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_NJhpUItsEeSDLd7nI4Quzw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment9 Environment { get; init; }
}
