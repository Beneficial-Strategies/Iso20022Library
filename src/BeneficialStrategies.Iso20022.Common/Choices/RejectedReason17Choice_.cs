// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason17Choice.Code))]
    [KnownType(typeof(RejectedReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason17Choice.Code),nameof(RejectedReason17Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason17Choice.Proprietary),nameof(RejectedReason17Choice.Proprietary))]
    [IsoId("_-Fir4SYuEeW_ZNn8gbfY7Q")]
    [DisplayName("Rejected Reason 17 Choice")]
    public abstract partial record RejectedReason17Choice_
    {
    }
}
