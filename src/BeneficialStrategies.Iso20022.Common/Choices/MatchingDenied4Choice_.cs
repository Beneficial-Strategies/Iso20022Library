// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(MatchingDenied4Choice.Code))]
    [KnownType(typeof(MatchingDenied4Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingDenied4Choice.Code), nameof(MatchingDenied4Choice.Code))]
    [JsonDerivedType(
        typeof(MatchingDenied4Choice.Proprietary),
        nameof(MatchingDenied4Choice.Proprietary)
    )]
    [IsoId("_6GWWDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Denied 4 Choice")]
    public abstract record MatchingDenied4Choice_ { }
}
