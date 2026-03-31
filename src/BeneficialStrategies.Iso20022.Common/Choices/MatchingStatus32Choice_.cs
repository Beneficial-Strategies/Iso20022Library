// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus32Choice.Matched))]
    [KnownType(typeof(MatchingStatus32Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus32Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus32Choice.Matched),
        nameof(MatchingStatus32Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus32Choice.Unmatched),
        nameof(MatchingStatus32Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus32Choice.Proprietary),
        nameof(MatchingStatus32Choice.Proprietary)
    )]
    [IsoId("_6d8XS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 32 Choice")]
    public abstract record MatchingStatus32Choice_ { }
}
