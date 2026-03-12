// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the contract was cleared or not.
    /// </summary>
    [KnownType(typeof(Cleared16Choice.Cleared))]
    [KnownType(typeof(Cleared16Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared16Choice.Cleared),nameof(Cleared16Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared16Choice.NonCleared),nameof(Cleared16Choice.NonCleared))]
    [IsoId("_gJAM4cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Cleared 16 Choice")]
    public abstract partial record Cleared16Choice_
    {
    }
}
