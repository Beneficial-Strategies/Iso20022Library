// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason8Choice.Code))]
    [KnownType(typeof(UnmatchedReason8Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason8Choice.Code), nameof(UnmatchedReason8Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason8Choice.Proprietary),
        nameof(UnmatchedReason8Choice.Proprietary)
    )]
    [IsoId("_E2Dtd_4hEeCH9dkaY_DhYw")]
    [DisplayName("Unmatched Reason 8 Choice")]
    public abstract record UnmatchedReason8Choice_ { }
}
