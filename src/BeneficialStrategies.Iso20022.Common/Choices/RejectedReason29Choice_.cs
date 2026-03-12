// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason29Choice.Code))]
    [KnownType(typeof(RejectedReason29Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason29Choice.Code),nameof(RejectedReason29Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason29Choice.Proprietary),nameof(RejectedReason29Choice.Proprietary))]
    [IsoId("_lrhy6bKhEemux5trsZcCpw")]
    [DisplayName("Rejected Reason 29 Choice")]
    public abstract partial record RejectedReason29Choice_
    {
    }
}
