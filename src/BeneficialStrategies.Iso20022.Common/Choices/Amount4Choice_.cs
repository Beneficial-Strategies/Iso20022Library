// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Amount4Choice.
    /// </summary>
    [KnownType(typeof(Amount4Choice.DecreaseAmount))]
    [KnownType(typeof(Amount4Choice.IncreaseAmount))]
    [JsonDerivedType(typeof(Amount4Choice.DecreaseAmount), nameof(Amount4Choice.DecreaseAmount))]
    [JsonDerivedType(typeof(Amount4Choice.IncreaseAmount), nameof(Amount4Choice.IncreaseAmount))]
    [IsoId("_wO4M0zH8Ee6mzvR3CHiUhA")]
    [DisplayName("Amount4Choice")]
    public abstract record Amount4Choice_ { }
}
