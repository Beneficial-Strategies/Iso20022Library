// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason10Choice.Code))]
    [KnownType(typeof(UnmatchedReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason10Choice.Code), nameof(UnmatchedReason10Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason10Choice.Proprietary),
        nameof(UnmatchedReason10Choice.Proprietary)
    )]
    [IsoId("_EhheOf7ZEeCtrO5qCU90cA")]
    [DisplayName("Unmatched Reason 10 Choice")]
    public abstract record UnmatchedReason10Choice_ { }
}
