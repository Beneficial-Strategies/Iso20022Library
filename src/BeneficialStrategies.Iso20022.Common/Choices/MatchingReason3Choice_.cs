// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason3Choice.Reason))]
    [KnownType(typeof(MatchingReason3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(MatchingReason3Choice.Reason),nameof(MatchingReason3Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason3Choice.NoSpecifiedReason),nameof(MatchingReason3Choice.NoSpecifiedReason))]
    [IsoId("_Az7z0NokEeC60axPepSq7g_-1866135956")]
    [DisplayName("Matching Reason 3 Choice")]
    public abstract partial record MatchingReason3Choice_
    {
    }
}
