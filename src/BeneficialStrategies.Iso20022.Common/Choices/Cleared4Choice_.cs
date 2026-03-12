// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [KnownType(typeof(Cleared4Choice.Cleared))]
    [KnownType(typeof(Cleared4Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared4Choice.Cleared),nameof(Cleared4Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared4Choice.NonCleared),nameof(Cleared4Choice.NonCleared))]
    [IsoId("_UM6SwCUMEeeDvf1E8-5blA")]
    [DisplayName("Cleared 4 Choice")]
    public abstract partial record Cleared4Choice_
    {
    }
}
