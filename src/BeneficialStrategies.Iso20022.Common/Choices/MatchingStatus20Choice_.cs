// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus20Choice.Matched))]
    [KnownType(typeof(MatchingStatus20Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus20Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus20Choice.Matched),
        nameof(MatchingStatus20Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus20Choice.Unmatched),
        nameof(MatchingStatus20Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus20Choice.Proprietary),
        nameof(MatchingStatus20Choice.Proprietary)
    )]
    [IsoId("_YN9u4SwjEeOEV5XHD-BKpw")]
    [DisplayName("Matching Status 20 Choice")]
    public abstract record MatchingStatus20Choice_ { }
}
