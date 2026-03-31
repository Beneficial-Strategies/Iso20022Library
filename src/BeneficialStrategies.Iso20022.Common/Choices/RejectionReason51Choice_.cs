// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason51Choice.Code))]
    [KnownType(typeof(RejectionReason51Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason51Choice.Code), nameof(RejectionReason51Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason51Choice.Proprietary),
        nameof(RejectionReason51Choice.Proprietary)
    )]
    [IsoId("_gARf6Ti8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 51 Choice")]
    public abstract record RejectionReason51Choice_ { }
}
