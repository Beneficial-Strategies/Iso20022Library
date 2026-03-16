// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the contract was cleared or not.
    /// </summary>
    [KnownType(typeof(Cleared9Choice.Cleared))]
    [KnownType(typeof(Cleared9Choice.NonCleared))]
    [JsonDerivedType(typeof(Cleared9Choice.Cleared), nameof(Cleared9Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared9Choice.NonCleared), nameof(Cleared9Choice.NonCleared))]
    [IsoId("_4fWa8ZQPEeiok48Eh9lW9Q")]
    [DisplayName("Cleared 9 Choice")]
    public abstract record Cleared9Choice_ { }
}
