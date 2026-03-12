// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason43Choice.Code))]
    [KnownType(typeof(RejectedReason43Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason43Choice.Code),nameof(RejectedReason43Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason43Choice.Proprietary),nameof(RejectedReason43Choice.Proprietary))]
    [IsoId("_LAYSExn1EeyroI8qKgB7Mg")]
    [DisplayName("Rejected Reason 43 Choice")]
    public abstract partial record RejectedReason43Choice_
    {
    }
}
