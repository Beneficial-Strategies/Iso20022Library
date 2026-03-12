// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus26Choice.Matched))]
    [KnownType(typeof(MatchingStatus26Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus26Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus26Choice.Matched),nameof(MatchingStatus26Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus26Choice.Unmatched),nameof(MatchingStatus26Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus26Choice.Proprietary),nameof(MatchingStatus26Choice.Proprietary))]
    [IsoId("_04bG4Tp4EeWVrPy0StzzSg")]
    [DisplayName("Matching Status 26 Choice")]
    public abstract partial record MatchingStatus26Choice_
    {
    }
}
