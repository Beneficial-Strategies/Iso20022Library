// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(MatchingDenied3Choice.Code))]
    [KnownType(typeof(MatchingDenied3Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingDenied3Choice.Code), nameof(MatchingDenied3Choice.Code))]
    [JsonDerivedType(
        typeof(MatchingDenied3Choice.Proprietary),
        nameof(MatchingDenied3Choice.Proprietary)
    )]
    [IsoId("_ZYK_kTt4EeW638lNyHKv7A")]
    [DisplayName("Matching Denied 3 Choice")]
    public abstract record MatchingDenied3Choice_ { }
}
