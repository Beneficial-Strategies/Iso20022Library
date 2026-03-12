// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason3Choice.Code))]
    [KnownType(typeof(RejectedReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason3Choice.Code),nameof(RejectedReason3Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason3Choice.Proprietary),nameof(RejectedReason3Choice.Proprietary))]
    [IsoId("_INQS8xdTEeK5g-3oYI0_9Q")]
    [DisplayName("Rejected Reason 3 Choice")]
    public abstract partial record RejectedReason3Choice_
    {
    }
}
