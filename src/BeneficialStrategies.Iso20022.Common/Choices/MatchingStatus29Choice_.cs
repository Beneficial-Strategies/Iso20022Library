// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus29Choice.Matched))]
    [KnownType(typeof(MatchingStatus29Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus29Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus29Choice.Matched),nameof(MatchingStatus29Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus29Choice.Unmatched),nameof(MatchingStatus29Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus29Choice.Proprietary),nameof(MatchingStatus29Choice.Proprietary))]
    [IsoId("_6BH3wZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 29 Choice")]
    public abstract partial record MatchingStatus29Choice_
    {
    }
}
