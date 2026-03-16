// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason13Choice.Code))]
    [KnownType(typeof(RejectedReason13Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason13Choice.Code), nameof(RejectedReason13Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason13Choice.Proprietary),
        nameof(RejectedReason13Choice.Proprietary)
    )]
    [IsoId("_9p3MUUGUEeWqy4niLuXETA")]
    [DisplayName("Rejected Reason 13 Choice")]
    public abstract record RejectedReason13Choice_ { }
}
