// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the matching.
    /// </summary>
    [KnownType(typeof(MatchingStatus23Choice.Matched))]
    [KnownType(typeof(MatchingStatus23Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus23Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus23Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus23Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.Matched),nameof(MatchingStatus23Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.MatchedWithTolerance),nameof(MatchingStatus23Choice.MatchedWithTolerance))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.MatchingAlleged),nameof(MatchingStatus23Choice.MatchingAlleged))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.Unmatched),nameof(MatchingStatus23Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.ProprietaryStatus),nameof(MatchingStatus23Choice.ProprietaryStatus))]
    [IsoId("_0pUxkWXREeOWzsrIp2keDA")]
    [DisplayName("Matching Status 23 Choice")]
    public abstract partial record MatchingStatus23Choice_
    {
    }
}
