// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason16Choice.Code))]
    [KnownType(typeof(RejectedReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason16Choice.Code), nameof(RejectedReason16Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason16Choice.Proprietary),
        nameof(RejectedReason16Choice.Proprietary)
    )]
    [IsoId("_u7hOkWOAEeWwOJYz8znDIw")]
    [DisplayName("Rejected Reason 16 Choice")]
    public abstract record RejectedReason16Choice_ { }
}
