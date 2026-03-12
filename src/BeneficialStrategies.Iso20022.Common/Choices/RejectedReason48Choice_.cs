// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason48Choice.Code))]
    [KnownType(typeof(RejectedReason48Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason48Choice.Code),nameof(RejectedReason48Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason48Choice.Proprietary),nameof(RejectedReason48Choice.Proprietary))]
    [IsoId("_peWZRTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Reason 48 Choice")]
    public abstract partial record RejectedReason48Choice_
    {
    }
}
