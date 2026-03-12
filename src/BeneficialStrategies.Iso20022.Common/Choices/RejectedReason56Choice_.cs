// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason56Choice.Code))]
    [KnownType(typeof(RejectedReason56Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason56Choice.Code),nameof(RejectedReason56Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason56Choice.Proprietary),nameof(RejectedReason56Choice.Proprietary))]
    [IsoId("_NpuWZF99Ee262vCSVgjImg")]
    [DisplayName("Rejected Reason 56 Choice")]
    public abstract partial record RejectedReason56Choice_
    {
    }
}
