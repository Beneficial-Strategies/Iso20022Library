// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason1Choice.Reason))]
    [KnownType(typeof(MatchingReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(MatchingReason1Choice.Reason), nameof(MatchingReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(MatchingReason1Choice.NoSpecifiedReason),
        nameof(MatchingReason1Choice.NoSpecifiedReason)
    )]
    [IsoId("_Az7z09okEeC60axPepSq7g_944348200")]
    [DisplayName("Matching Reason 1 Choice")]
    public abstract record MatchingReason1Choice_ { }
}
