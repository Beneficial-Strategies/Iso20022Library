// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus7Choice.Matched))]
    [KnownType(typeof(MatchingStatus7Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus7Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus7Choice.Matched), nameof(MatchingStatus7Choice.Matched))]
    [JsonDerivedType(
        typeof(MatchingStatus7Choice.Unmatched),
        nameof(MatchingStatus7Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus7Choice.Proprietary),
        nameof(MatchingStatus7Choice.Proprietary)
    )]
    [IsoId("_GJDy8f5WEeCtrO5qCU90cA")]
    [DisplayName("Matching Status 7 Choice")]
    public abstract record MatchingStatus7Choice_ { }
}
