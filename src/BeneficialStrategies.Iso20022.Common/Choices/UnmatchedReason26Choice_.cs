// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason26Choice.Code))]
    [KnownType(typeof(UnmatchedReason26Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason26Choice.Code), nameof(UnmatchedReason26Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason26Choice.Proprietary),
        nameof(UnmatchedReason26Choice.Proprietary)
    )]
    [IsoId("_6QAoUZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Reason 26 Choice")]
    public abstract record UnmatchedReason26Choice_ { }
}
