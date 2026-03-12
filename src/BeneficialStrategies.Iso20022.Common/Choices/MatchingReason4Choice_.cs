// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason4Choice.Reason))]
    [KnownType(typeof(MatchingReason4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(MatchingReason4Choice.Reason),nameof(MatchingReason4Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason4Choice.NoSpecifiedReason),nameof(MatchingReason4Choice.NoSpecifiedReason))]
    [IsoId("_1Bk5i2XREeOWzsrIp2keDA")]
    [DisplayName("Matching Reason 4 Choice")]
    public abstract partial record MatchingReason4Choice_
    {
    }
}
