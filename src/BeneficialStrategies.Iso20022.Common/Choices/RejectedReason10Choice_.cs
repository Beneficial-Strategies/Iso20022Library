// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason10Choice.Code))]
    [KnownType(typeof(RejectedReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason10Choice.Code), nameof(RejectedReason10Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason10Choice.Proprietary),
        nameof(RejectedReason10Choice.Proprietary)
    )]
    [IsoId("_2dRqY1hnEeSsH9MSoogb7Q")]
    [DisplayName("Rejected Reason 10 Choice")]
    public abstract record RejectedReason10Choice_ { }
}
