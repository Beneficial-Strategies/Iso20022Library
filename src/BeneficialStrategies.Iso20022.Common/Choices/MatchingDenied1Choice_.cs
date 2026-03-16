// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [KnownType(typeof(MatchingDenied1Choice.Code))]
    [KnownType(typeof(MatchingDenied1Choice.Proprietary))]
    [JsonDerivedType(typeof(MatchingDenied1Choice.Code), nameof(MatchingDenied1Choice.Code))]
    [JsonDerivedType(
        typeof(MatchingDenied1Choice.Proprietary),
        nameof(MatchingDenied1Choice.Proprietary)
    )]
    [IsoId("_UakE1Np-Ed-ak6NoX_4Aeg_-1854020837")]
    [DisplayName("Matching Denied 1 Choice")]
    public abstract record MatchingDenied1Choice_ { }
}
