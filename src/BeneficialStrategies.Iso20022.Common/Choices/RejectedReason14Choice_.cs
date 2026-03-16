// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason14Choice.Code))]
    [KnownType(typeof(RejectedReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason14Choice.Code), nameof(RejectedReason14Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason14Choice.Proprietary),
        nameof(RejectedReason14Choice.Proprietary)
    )]
    [IsoId("_GYznk0GXEeWqy4niLuXETA")]
    [DisplayName("Rejected Reason 14 Choice")]
    public abstract record RejectedReason14Choice_ { }
}
