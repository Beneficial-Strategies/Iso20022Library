// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the control of an ATM device.
/// </summary>
[IsoId("_p87DYItEEeSxlKlAGYErFg")]
[DisplayName("ATM Device Control")]
public record ATMDeviceControl1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_EruoUItFEeSxlKlAGYErFg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required ATMEnvironment7 Environment { get; init; }

    /// <summary>
    /// Maintenance command the ATM must perform.
    /// </summary>
    [IsoId("_laaFAItFEeSxlKlAGYErFg")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand4> Command { get; init; } = [];
}
