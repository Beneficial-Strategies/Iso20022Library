// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the contract was cleared or not.
    /// </summary>
    [KnownType(typeof(Cleared10Choice.Cleared))]
    [KnownType(typeof(Cleared10Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared10Choice.Cleared),nameof(Cleared10Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared10Choice.NonCleared),nameof(Cleared10Choice.NonCleared))]
    [IsoId("_HMdnQbQ0EemI67HK7aviyg")]
    [DisplayName("Cleared 10 Choice")]
    public abstract partial record Cleared10Choice_
    {
    }
}
