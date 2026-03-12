// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason5Choice.Reason))]
    [KnownType(typeof(MatchingReason5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(MatchingReason5Choice.Reason),nameof(MatchingReason5Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason5Choice.NoSpecifiedReason),nameof(MatchingReason5Choice.NoSpecifiedReason))]
    [IsoId("_2sTZ-wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Matching Reason 5 Choice")]
    public abstract partial record MatchingReason5Choice_
    {
    }
}
