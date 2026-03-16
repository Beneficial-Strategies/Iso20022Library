// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason25Choice.Code))]
    [KnownType(typeof(UnmatchedReason25Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason25Choice.Code), nameof(UnmatchedReason25Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason25Choice.Proprietary),
        nameof(UnmatchedReason25Choice.Proprietary)
    )]
    [IsoId("_6BIelZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Reason 25 Choice")]
    public abstract record UnmatchedReason25Choice_ { }
}
