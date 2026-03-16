// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason10Choice.Code))]
    [KnownType(typeof(RejectionReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason10Choice.Code), nameof(RejectionReason10Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason10Choice.Proprietary),
        nameof(RejectionReason10Choice.Proprietary)
    )]
    [IsoId("__qYfr_4wEeClUvPNHKL9Zw")]
    [DisplayName("Rejection Reason 10 Choice")]
    public abstract record RejectionReason10Choice_ { }
}
