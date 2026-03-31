// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason3Choice.Code))]
    [KnownType(typeof(UnmatchedReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason3Choice.Code), nameof(UnmatchedReason3Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason3Choice.Proprietary),
        nameof(UnmatchedReason3Choice.Proprietary)
    )]
    [IsoId("_UWYvd9p-Ed-ak6NoX_4Aeg_1064638160")]
    [DisplayName("Unmatched Reason 3 Choice")]
    public abstract record UnmatchedReason3Choice_ { }
}
