// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason19Choice.Code))]
    [KnownType(typeof(RejectedReason19Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason19Choice.Code), nameof(RejectedReason19Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason19Choice.Proprietary),
        nameof(RejectedReason19Choice.Proprietary)
    )]
    [IsoId("_cgn4b5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rejected Reason 19 Choice")]
    public abstract record RejectedReason19Choice_ { }
}
