// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specific parameters attached to an ATM command.
    /// </summary>
    [KnownType(typeof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters3Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters3Choice.RequiredConfigurationParameter))]
    [KnownType(typeof(ATMCommandParameters3Choice.RequiredSecurityScheme))]
    [KnownType(typeof(ATMCommandParameters3Choice.SecurityDevice))]
    [KnownType(typeof(ATMCommandParameters3Choice.Key))]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus),
        nameof(ATMCommandParameters3Choice.ATMRequiredGlobalStatus)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.ExpectedMessageFunction),
        nameof(ATMCommandParameters3Choice.ExpectedMessageFunction)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.RequiredConfigurationParameter),
        nameof(ATMCommandParameters3Choice.RequiredConfigurationParameter)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.RequiredSecurityScheme),
        nameof(ATMCommandParameters3Choice.RequiredSecurityScheme)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.SecurityDevice),
        nameof(ATMCommandParameters3Choice.SecurityDevice)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters3Choice.Key),
        nameof(ATMCommandParameters3Choice.Key)
    )]
    [IsoId("_hk_BUV2aEeekzJIz1JxYSQ")]
    [DisplayName("ATM Command Parameters 3 Choice")]
    public abstract record ATMCommandParameters3Choice_ { }
}
