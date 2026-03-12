// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason37Choice.Code))]
    [KnownType(typeof(RejectedReason37Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason37Choice.Code),nameof(RejectedReason37Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason37Choice.Proprietary),nameof(RejectedReason37Choice.Proprietary))]
    [IsoId("_GmDA8xHqEeuE0Pnt-OcNOA")]
    [DisplayName("Rejected Reason 37 Choice")]
    public abstract partial record RejectedReason37Choice_
    {
    }
}
