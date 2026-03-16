// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason47Choice.Code))]
    [KnownType(typeof(RejectionReason47Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason47Choice.Code), nameof(RejectionReason47Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason47Choice.Proprietary),
        nameof(RejectionReason47Choice.Proprietary)
    )]
    [IsoId("_dszBUDi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 47 Choice")]
    public abstract record RejectionReason47Choice_ { }
}
