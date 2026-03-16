// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason15Choice.Code))]
    [KnownType(typeof(UnmatchedReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason15Choice.Code), nameof(UnmatchedReason15Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason15Choice.Proprietary),
        nameof(UnmatchedReason15Choice.Proprietary)
    )]
    [IsoId("_6f3HQSwiEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Reason 15 Choice")]
    public abstract record UnmatchedReason15Choice_ { }
}
