// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities financing unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason24Choice.Code))]
    [KnownType(typeof(UnmatchedReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason24Choice.Code), nameof(UnmatchedReason24Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason24Choice.Proprietary),
        nameof(UnmatchedReason24Choice.Proprietary)
    )]
    [IsoId("_DFsb-Tw8EeW3QqUkIQtIUA")]
    [DisplayName("Unmatched Reason 24 Choice")]
    public abstract record UnmatchedReason24Choice_ { }
}
