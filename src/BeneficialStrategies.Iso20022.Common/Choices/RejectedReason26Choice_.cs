// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason26Choice.Code))]
    [KnownType(typeof(RejectedReason26Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason26Choice.Code), nameof(RejectedReason26Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason26Choice.Proprietary),
        nameof(RejectedReason26Choice.Proprietary)
    )]
    [IsoId("_bzV1jffREeiNZp_PtLohLw")]
    [DisplayName("Rejected Reason 26 Choice")]
    public abstract record RejectedReason26Choice_ { }
}
