// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason45Choice.Code))]
    [KnownType(typeof(RejectionReason45Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason45Choice.Code), nameof(RejectionReason45Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason45Choice.Proprietary),
        nameof(RejectionReason45Choice.Proprietary)
    )]
    [IsoId("_8NNHLStXEeyhipY4f42fZQ")]
    [DisplayName("Rejection Reason 45 Choice")]
    public abstract record RejectionReason45Choice_ { }
}
