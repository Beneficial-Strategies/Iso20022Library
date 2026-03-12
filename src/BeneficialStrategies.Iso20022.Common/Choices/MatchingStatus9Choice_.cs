// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the matching.
    /// </summary>
    [KnownType(typeof(MatchingStatus9Choice.Matched))]
    [KnownType(typeof(MatchingStatus9Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus9Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus9Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus9Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.Matched),nameof(MatchingStatus9Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.MatchedWithTolerance),nameof(MatchingStatus9Choice.MatchedWithTolerance))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.MatchingAlleged),nameof(MatchingStatus9Choice.MatchingAlleged))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.Unmatched),nameof(MatchingStatus9Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.ProprietaryStatus),nameof(MatchingStatus9Choice.ProprietaryStatus))]
    [IsoId("_A4aEItokEeC60axPepSq7g_-668898951")]
    [DisplayName("Matching Status 9 Choice")]
    public abstract partial record MatchingStatus9Choice_
    {
    }
}
