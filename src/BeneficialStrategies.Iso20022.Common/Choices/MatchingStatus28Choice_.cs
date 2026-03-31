// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus28Choice.Code))]
    [KnownType(typeof(MatchingStatus28Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus28Choice.Code), nameof(MatchingStatus28Choice.Code))]
    [JsonDerivedType(
        typeof(MatchingStatus28Choice.Proprietary),
        nameof(MatchingStatus28Choice.Proprietary)
    )]
    [IsoId("_5xm1MZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 28 Choice")]
    public abstract record MatchingStatus28Choice_ { }
}
