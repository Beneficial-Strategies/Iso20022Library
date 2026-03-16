// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason43Choice.Code))]
    [KnownType(typeof(RejectionReason43Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason43Choice.Code), nameof(RejectionReason43Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason43Choice.Proprietary),
        nameof(RejectionReason43Choice.Proprietary)
    )]
    [IsoId("_r5kWAStWEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 43 Choice")]
    public abstract record RejectionReason43Choice_ { }
}
