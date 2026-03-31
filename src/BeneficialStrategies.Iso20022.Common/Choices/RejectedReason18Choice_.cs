// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason18Choice.Code))]
    [KnownType(typeof(RejectedReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason18Choice.Code), nameof(RejectedReason18Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason18Choice.Proprietary),
        nameof(RejectedReason18Choice.Proprietary)
    )]
    [IsoId("_ce_gcZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rejected Reason 18 Choice")]
    public abstract record RejectedReason18Choice_ { }
}
