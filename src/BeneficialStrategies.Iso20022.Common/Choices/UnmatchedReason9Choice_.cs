// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason9Choice.Code))]
    [KnownType(typeof(UnmatchedReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason9Choice.Code), nameof(UnmatchedReason9Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason9Choice.Proprietary),
        nameof(UnmatchedReason9Choice.Proprietary)
    )]
    [IsoId("_5xWgFf7YEeCtrO5qCU90cA")]
    [DisplayName("Unmatched Reason 9 Choice")]
    public abstract record UnmatchedReason9Choice_ { }
}
