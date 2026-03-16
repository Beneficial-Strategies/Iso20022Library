// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason33Choice.Code))]
    [KnownType(typeof(RejectionReason33Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason33Choice.Code), nameof(RejectionReason33Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason33Choice.Proprietary),
        nameof(RejectionReason33Choice.Proprietary)
    )]
    [IsoId("_8NoLbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 33 Choice")]
    public abstract record RejectionReason33Choice_ { }
}
