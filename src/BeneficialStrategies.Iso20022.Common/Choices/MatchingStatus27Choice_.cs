// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus27Choice.Code))]
    [KnownType(typeof(MatchingStatus27Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus27Choice.Code),nameof(MatchingStatus27Choice.Code))]
    [JsonDerivedType(typeof(MatchingStatus27Choice.Proprietary),nameof(MatchingStatus27Choice.Proprietary))]
    [IsoId("_YZLzYTqqEeWyoP0PbocV1Q")]
    [DisplayName("Matching Status 27 Choice")]
    public abstract partial record MatchingStatus27Choice_
    {
    }
}
