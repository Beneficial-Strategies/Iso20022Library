// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus12Choice.Matched))]
    [KnownType(typeof(MatchingStatus12Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus12Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus12Choice.Matched),nameof(MatchingStatus12Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus12Choice.Unmatched),nameof(MatchingStatus12Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus12Choice.Proprietary),nameof(MatchingStatus12Choice.Proprietary))]
    [IsoId("_EhXs4f7ZEeCtrO5qCU90cA")]
    [DisplayName("Matching Status 12 Choice")]
    public abstract partial record MatchingStatus12Choice_
    {
    }
}
