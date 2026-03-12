// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus8Choice.Code))]
    [KnownType(typeof(MatchingStatus8Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus8Choice.Code),nameof(MatchingStatus8Choice.Code))]
    [JsonDerivedType(typeof(MatchingStatus8Choice.Proprietary),nameof(MatchingStatus8Choice.Proprietary))]
    [IsoId("_A0Fk09okEeC60axPepSq7g_-730589199")]
    [DisplayName("Matching Status 8 Choice")]
    public abstract partial record MatchingStatus8Choice_
    {
    }
}
