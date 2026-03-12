// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason6Choice.Reason))]
    [KnownType(typeof(MatchingReason6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(MatchingReason6Choice.Reason),nameof(MatchingReason6Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason6Choice.NoSpecifiedReason),nameof(MatchingReason6Choice.NoSpecifiedReason))]
    [IsoId("_gV_p0Qd4Ee2fOITqoTnSLQ")]
    [DisplayName("Matching Reason 6 Choice")]
    public abstract partial record MatchingReason6Choice_
    {
    }
}
