// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus24Choice.Matched))]
    [KnownType(typeof(MatchingStatus24Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus24Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus24Choice.Matched),nameof(MatchingStatus24Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus24Choice.Unmatched),nameof(MatchingStatus24Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus24Choice.Proprietary),nameof(MatchingStatus24Choice.Proprietary))]
    [IsoId("_y0Sr8Tp4EeWVrPy0StzzSg")]
    [DisplayName("Matching Status 24 Choice")]
    public abstract partial record MatchingStatus24Choice_
    {
    }
}
