// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus30Choice.Matched))]
    [KnownType(typeof(MatchingStatus30Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus30Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus30Choice.Matched),
        nameof(MatchingStatus30Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus30Choice.Unmatched),
        nameof(MatchingStatus30Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus30Choice.Proprietary),
        nameof(MatchingStatus30Choice.Proprietary)
    )]
    [IsoId("_6QABl5NLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 30 Choice")]
    public abstract record MatchingStatus30Choice_ { }
}
