// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of the executing party.
    /// </summary>
    [KnownType(typeof(ExecutingParty1Choice.Person))]
    [KnownType(typeof(ExecutingParty1Choice.Algorithm))]
    [KnownType(typeof(ExecutingParty1Choice.Client))]
    [JsonDerivedType(typeof(ExecutingParty1Choice.Person), nameof(ExecutingParty1Choice.Person))]
    [JsonDerivedType(
        typeof(ExecutingParty1Choice.Algorithm),
        nameof(ExecutingParty1Choice.Algorithm)
    )]
    [JsonDerivedType(typeof(ExecutingParty1Choice.Client), nameof(ExecutingParty1Choice.Client))]
    [IsoId("_FVhI0ViJEea-d4CsgzjlAw")]
    [DisplayName("Executing Party 1 Choice")]
    public abstract record ExecutingParty1Choice_ { }
}
