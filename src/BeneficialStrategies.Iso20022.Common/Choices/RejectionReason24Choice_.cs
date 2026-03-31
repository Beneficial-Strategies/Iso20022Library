// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason24Choice.Code))]
    [KnownType(typeof(RejectionReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason24Choice.Code), nameof(RejectionReason24Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason24Choice.Proprietary),
        nameof(RejectionReason24Choice.Proprietary)
    )]
    [IsoId("_RqAvQTq2EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Reason 24 Choice")]
    public abstract record RejectionReason24Choice_ { }
}
