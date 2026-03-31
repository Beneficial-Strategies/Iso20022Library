// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus34Choice.Matched))]
    [KnownType(typeof(MatchingStatus34Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus34Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus34Choice.Matched),
        nameof(MatchingStatus34Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus34Choice.Unmatched),
        nameof(MatchingStatus34Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus34Choice.Proprietary),
        nameof(MatchingStatus34Choice.Proprietary)
    )]
    [IsoId("_yZ5IBxUHEeuZw7VHHgrHLg")]
    [DisplayName("Matching Status 34 Choice")]
    public abstract record MatchingStatus34Choice_ { }
}
