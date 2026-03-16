// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason26Choice.Code))]
    [KnownType(typeof(RejectionReason26Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason26Choice.Code), nameof(RejectionReason26Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason26Choice.Proprietary),
        nameof(RejectionReason26Choice.Proprietary)
    )]
    [IsoId("_chIb6Tw5EeW3QqUkIQtIUA")]
    [DisplayName("Rejection Reason 26 Choice")]
    public abstract record RejectionReason26Choice_ { }
}
