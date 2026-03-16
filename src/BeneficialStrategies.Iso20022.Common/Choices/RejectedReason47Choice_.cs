// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason47Choice.Code))]
    [KnownType(typeof(RejectedReason47Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason47Choice.Code), nameof(RejectedReason47Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason47Choice.Proprietary),
        nameof(RejectedReason47Choice.Proprietary)
    )]
    [IsoId("_pf-JgTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Reason 47 Choice")]
    public abstract record RejectedReason47Choice_ { }
}
