// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason22Choice.Code))]
    [KnownType(typeof(RejectedReason22Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason22Choice.Code), nameof(RejectedReason22Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason22Choice.Proprietary),
        nameof(RejectedReason22Choice.Proprietary)
    )]
    [IsoId("_HjQf44lqEeavwKddCbm3hg")]
    [DisplayName("Rejected Reason 22 Choice")]
    public abstract record RejectedReason22Choice_ { }
}
