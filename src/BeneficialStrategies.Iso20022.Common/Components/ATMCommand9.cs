// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party which has requested the reconciliation.
/// </summary>
[IsoId("_4eQxAa47EeWRfYPBaeOY8w")]
[DisplayName("ATM Command")]
public record ATMCommand9
{
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_4pcGQa47EeWRfYPBaeOY8w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand5Code Type { get; init; }

    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_4pcGQ647EeWRfYPBaeOY8w")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }
}
