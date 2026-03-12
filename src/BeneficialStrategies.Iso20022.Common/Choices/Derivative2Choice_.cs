// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice element to define a derivative instrument.
    /// </summary>
    [KnownType(typeof(Derivative2Choice.Commodity))]
    [KnownType(typeof(Derivative2Choice.InterestRate))]
    [KnownType(typeof(Derivative2Choice.ForeignExchange))]
    [KnownType(typeof(Derivative2Choice.Equity))]
    [KnownType(typeof(Derivative2Choice.ContractForDifference))]
    [KnownType(typeof(Derivative2Choice.Credit))]
    [KnownType(typeof(Derivative2Choice.EmissionAllowance))]
    [JsonDerivedType(typeof(Derivative2Choice.Commodity),nameof(Derivative2Choice.Commodity))]
    [JsonDerivedType(typeof(Derivative2Choice.InterestRate),nameof(Derivative2Choice.InterestRate))]
    [JsonDerivedType(typeof(Derivative2Choice.ForeignExchange),nameof(Derivative2Choice.ForeignExchange))]
    [JsonDerivedType(typeof(Derivative2Choice.Equity),nameof(Derivative2Choice.Equity))]
    [JsonDerivedType(typeof(Derivative2Choice.ContractForDifference),nameof(Derivative2Choice.ContractForDifference))]
    [JsonDerivedType(typeof(Derivative2Choice.Credit),nameof(Derivative2Choice.Credit))]
    [JsonDerivedType(typeof(Derivative2Choice.EmissionAllowance),nameof(Derivative2Choice.EmissionAllowance))]
    [IsoId("_BmdSAWkwEeaLAKoEUNsD9g")]
    [DisplayName("Derivative 2 Choice")]
    public abstract partial record Derivative2Choice_
    {
    }
}
