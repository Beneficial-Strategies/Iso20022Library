// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus19Choice.Matched))]
    [KnownType(typeof(MatchingStatus19Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus19Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus19Choice.Matched),
        nameof(MatchingStatus19Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus19Choice.Unmatched),
        nameof(MatchingStatus19Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus19Choice.Proprietary),
        nameof(MatchingStatus19Choice.Proprietary)
    )]
    [IsoId("_ZlY6ASwREeOEV5XHD-BKpw")]
    [DisplayName("Matching Status 19 Choice")]
    public abstract record MatchingStatus19Choice_ { }
}
