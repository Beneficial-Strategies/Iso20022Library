// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the matching.
    /// </summary>
    [KnownType(typeof(MatchingStatus35Choice.Matched))]
    [KnownType(typeof(MatchingStatus35Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus35Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus35Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus35Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(MatchingStatus35Choice.Matched),
        nameof(MatchingStatus35Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus35Choice.MatchedWithTolerance),
        nameof(MatchingStatus35Choice.MatchedWithTolerance)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus35Choice.MatchingAlleged),
        nameof(MatchingStatus35Choice.MatchingAlleged)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus35Choice.Unmatched),
        nameof(MatchingStatus35Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus35Choice.ProprietaryStatus),
        nameof(MatchingStatus35Choice.ProprietaryStatus)
    )]
    [IsoId("_2W_4UQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Matching Status 35 Choice")]
    public abstract record MatchingStatus35Choice_ { }
}
