// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of interest rate of the loan.
    /// </summary>
    [KnownType(typeof(Rates1Choice.Fixed))]
    [KnownType(typeof(Rates1Choice.Floating))]
    [JsonDerivedType(typeof(Rates1Choice.Fixed),nameof(Rates1Choice.Fixed))]
    [JsonDerivedType(typeof(Rates1Choice.Floating),nameof(Rates1Choice.Floating))]
    [IsoId("_4OX54Hg1EeuXJdYjLmnO3w")]
    [DisplayName("Rates 1 Choice")]
    public abstract partial record Rates1Choice_
    {
    }
}
