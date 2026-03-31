// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason17Choice.Code))]
    [KnownType(typeof(RejectionReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason17Choice.Code), nameof(RejectionReason17Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason17Choice.Proprietary),
        nameof(RejectionReason17Choice.Proprietary)
    )]
    [IsoId("_CF-CICzVEeOsiuMH68so7Q")]
    [DisplayName("Rejection Reason 17 Choice")]
    public abstract record RejectionReason17Choice_ { }
}
