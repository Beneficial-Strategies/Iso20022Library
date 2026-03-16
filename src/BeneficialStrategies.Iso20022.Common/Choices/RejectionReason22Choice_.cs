// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason22Choice.Code))]
    [KnownType(typeof(RejectionReason22Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason22Choice.Code), nameof(RejectionReason22Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason22Choice.Proprietary),
        nameof(RejectionReason22Choice.Proprietary)
    )]
    [IsoId("_Hl6w4TqyEeWyoP0PbocV1Q")]
    [DisplayName("Rejection Reason 22 Choice")]
    public abstract record RejectionReason22Choice_ { }
}
