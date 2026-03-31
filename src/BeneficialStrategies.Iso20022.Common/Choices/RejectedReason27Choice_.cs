// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason27Choice.Code))]
    [KnownType(typeof(RejectedReason27Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason27Choice.Code), nameof(RejectedReason27Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason27Choice.Proprietary),
        nameof(RejectedReason27Choice.Proprietary)
    )]
    [IsoId("_TF2qkf0uEeiKOe8GCUL1Lg")]
    [DisplayName("Rejected Reason 27 Choice")]
    public abstract record RejectedReason27Choice_ { }
}
