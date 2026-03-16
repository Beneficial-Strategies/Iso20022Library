// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason41Choice.Code))]
    [KnownType(typeof(RejectedReason41Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason41Choice.Code), nameof(RejectedReason41Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason41Choice.Proprietary),
        nameof(RejectedReason41Choice.Proprietary)
    )]
    [IsoId("_ec6qoxnyEeyroI8qKgB7Mg")]
    [DisplayName("Rejected Reason 41 Choice")]
    public abstract record RejectedReason41Choice_ { }
}
