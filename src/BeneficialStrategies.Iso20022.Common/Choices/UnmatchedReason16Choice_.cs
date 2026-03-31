// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement query unmatched reason.
    /// </summary>
    [KnownType(typeof(UnmatchedReason16Choice.Code))]
    [KnownType(typeof(UnmatchedReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(UnmatchedReason16Choice.Code), nameof(UnmatchedReason16Choice.Code))]
    [JsonDerivedType(
        typeof(UnmatchedReason16Choice.Proprietary),
        nameof(UnmatchedReason16Choice.Proprietary)
    )]
    [IsoId("_zbyVoSwkEeOEV5XHD-BKpw")]
    [DisplayName("Unmatched Reason 16 Choice")]
    public abstract record UnmatchedReason16Choice_ { }
}
