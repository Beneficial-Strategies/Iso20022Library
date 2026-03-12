// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason5Choice.Code))]
    [KnownType(typeof(RejectedReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason5Choice.Code),nameof(RejectedReason5Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason5Choice.Proprietary),nameof(RejectedReason5Choice.Proprietary))]
    [IsoId("_P9as4yd0EeOXAt_43VmZGw")]
    [DisplayName("Rejected Reason 5 Choice")]
    public abstract partial record RejectedReason5Choice_
    {
    }
}
