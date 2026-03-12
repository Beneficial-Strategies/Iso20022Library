// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason34Choice.Code))]
    [KnownType(typeof(RejectedReason34Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason34Choice.Code),nameof(RejectedReason34Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason34Choice.Proprietary),nameof(RejectedReason34Choice.Proprietary))]
    [IsoId("_cFKuE-6BEeqc-LCjwLsUVg")]
    [DisplayName("Rejected Reason 34 Choice")]
    public abstract partial record RejectedReason34Choice_
    {
    }
}
