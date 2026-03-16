// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus3Choice.Matched))]
    [KnownType(typeof(MatchingStatus3Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingStatus3Choice.Matched), nameof(MatchingStatus3Choice.Matched))]
    [JsonDerivedType(
        typeof(MatchingStatus3Choice.Unmatched),
        nameof(MatchingStatus3Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(MatchingStatus3Choice.Proprietary),
        nameof(MatchingStatus3Choice.Proprietary)
    )]
    [IsoId("_UWF0hNp-Ed-ak6NoX_4Aeg_960279555")]
    [DisplayName("Matching Status 3 Choice")]
    public abstract record MatchingStatus3Choice_ { }
}
