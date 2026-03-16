// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specific parameters attached to an ATM command.
    /// </summary>
    [KnownType(typeof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters1Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters1Choice.RequiredConfigurationParameter))]
    [JsonDerivedType(
        typeof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus),
        nameof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters1Choice.ExpectedMessageFunction),
        nameof(ATMCommandParameters1Choice.ExpectedMessageFunction)
    )]
    [JsonDerivedType(
        typeof(ATMCommandParameters1Choice.RequiredConfigurationParameter),
        nameof(ATMCommandParameters1Choice.RequiredConfigurationParameter)
    )]
    [IsoId("_JTG3oIqLEeSRT5rEzcAHEw")]
    [DisplayName("ATM Command Parameters 1 Choice")]
    public abstract record ATMCommandParameters1Choice_ { }
}
