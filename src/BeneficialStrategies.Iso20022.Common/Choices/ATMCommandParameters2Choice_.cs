// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specific parameters attached to an ATM command.
    /// </summary>
    [KnownType(typeof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters2Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters2Choice.RequiredConfigurationParameter))]
    [KnownType(typeof(ATMCommandParameters2Choice.RequiredSecurityScheme))]
    [KnownType(typeof(ATMCommandParameters2Choice.SecurityDevice))]
    [KnownType(typeof(ATMCommandParameters2Choice.Key))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus),nameof(ATMCommandParameters2Choice.ATMRequiredGlobalStatus))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.ExpectedMessageFunction),nameof(ATMCommandParameters2Choice.ExpectedMessageFunction))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.RequiredConfigurationParameter),nameof(ATMCommandParameters2Choice.RequiredConfigurationParameter))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.RequiredSecurityScheme),nameof(ATMCommandParameters2Choice.RequiredSecurityScheme))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.SecurityDevice),nameof(ATMCommandParameters2Choice.SecurityDevice))]
    [JsonDerivedType(typeof(ATMCommandParameters2Choice.Key),nameof(ATMCommandParameters2Choice.Key))]
    [IsoId("_pz3tsYtHEeSxlKlAGYErFg")]
    [DisplayName("ATM Command Parameters 2 Choice")]
    public abstract partial record ATMCommandParameters2Choice_
    {
    }
}
