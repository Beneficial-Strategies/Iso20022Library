// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command which has requested the device report.
/// </summary>
[IsoId("_bfXL4V_UEeeD0NpJQPACzA")]
[DisplayName("ATM Command")]
public record ATMCommand12
{
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_bnvr0V_UEeeD0NpJQPACzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand6Code Type { get; init; }

    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_bnvr01_UEeeD0NpJQPACzA")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }
}
