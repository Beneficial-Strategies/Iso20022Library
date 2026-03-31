// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the contract was cleared, not cleared or if the contract is intended to be cleared.
    /// </summary>
    [KnownType(typeof(Cleared23Choice.Cleared))]
    [KnownType(typeof(Cleared23Choice.IntendToClear))]
    [KnownType(typeof(Cleared23Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared23Choice.Cleared), nameof(Cleared23Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared23Choice.IntendToClear), nameof(Cleared23Choice.IntendToClear))]
    [JsonDerivedType(typeof(Cleared23Choice.NonCleared), nameof(Cleared23Choice.NonCleared))]
    [IsoId("_zVhWIQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Cleared 23 Choice")]
    public abstract record Cleared23Choice_ { }
}
