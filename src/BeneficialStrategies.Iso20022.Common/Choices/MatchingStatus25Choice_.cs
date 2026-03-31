// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus25Choice.Matched))]
    [KnownType(typeof(MatchingStatus25Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MatchingStatus25Choice.Matched),
        nameof(MatchingStatus25Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus25Choice.Unmatched),
        nameof(MatchingStatus25Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus25Choice.Proprietary),
        nameof(MatchingStatus25Choice.Proprietary)
    )]
    [IsoId("_0XRhsTp4EeWVrPy0StzzSg")]
    [DisplayName("Matching Status 25 Choice")]
    public abstract record MatchingStatus25Choice_ { }
}
