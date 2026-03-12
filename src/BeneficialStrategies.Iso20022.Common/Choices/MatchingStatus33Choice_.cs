// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [KnownType(typeof(MatchingStatus33Choice.Matched))]
    [KnownType(typeof(MatchingStatus33Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus33Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus33Choice.Matched),nameof(MatchingStatus33Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus33Choice.Unmatched),nameof(MatchingStatus33Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus33Choice.Proprietary),nameof(MatchingStatus33Choice.Proprietary))]
    [IsoId("_7lZ_IOB9Eei2UYJ62ws-Fw")]
    [DisplayName("Matching Status 33 Choice")]
    public abstract partial record MatchingStatus33Choice_
    {
    }
}
