// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason46Choice.Code))]
    [KnownType(typeof(RejectedReason46Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason46Choice.Code),nameof(RejectedReason46Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason46Choice.Proprietary),nameof(RejectedReason46Choice.Proprietary))]
    [IsoId("_piJT7zi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Reason 46 Choice")]
    public abstract partial record RejectedReason46Choice_
    {
    }
}
