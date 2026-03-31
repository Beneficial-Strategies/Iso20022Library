// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason38Choice.Code))]
    [KnownType(typeof(RejectedReason38Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason38Choice.Code), nameof(RejectedReason38Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason38Choice.Proprietary),
        nameof(RejectedReason38Choice.Proprietary)
    )]
    [IsoId("_KOxgQxUNEeuYppTwWp55gA")]
    [DisplayName("Rejected Reason 38 Choice")]
    public abstract record RejectedReason38Choice_ { }
}
