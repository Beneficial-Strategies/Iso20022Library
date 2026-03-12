// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason42Choice.Code))]
    [KnownType(typeof(RejectedReason42Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason42Choice.Code),nameof(RejectedReason42Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason42Choice.Proprietary),nameof(RejectedReason42Choice.Proprietary))]
    [IsoId("_WmtRcxn0EeyroI8qKgB7Mg")]
    [DisplayName("Rejected Reason 42 Choice")]
    public abstract partial record RejectedReason42Choice_
    {
    }
}
