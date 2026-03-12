// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason35Choice.Code))]
    [KnownType(typeof(RejectedReason35Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason35Choice.Code),nameof(RejectedReason35Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason35Choice.Proprietary),nameof(RejectedReason35Choice.Proprietary))]
    [IsoId("_5rHJI-6KEeqc-LCjwLsUVg")]
    [DisplayName("Rejected Reason 35 Choice")]
    public abstract partial record RejectedReason35Choice_
    {
    }
}
