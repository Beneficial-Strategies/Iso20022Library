// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason46Choice.Code))]
    [KnownType(typeof(RejectionReason46Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason46Choice.Code), nameof(RejectionReason46Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason46Choice.Proprietary),
        nameof(RejectionReason46Choice.Proprietary)
    )]
    [IsoId("_ddA4qzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 46 Choice")]
    public abstract record RejectionReason46Choice_ { }
}
