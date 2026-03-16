// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason11Choice.Code))]
    [KnownType(typeof(RejectionReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason11Choice.Code), nameof(RejectionReason11Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason11Choice.Proprietary),
        nameof(RejectionReason11Choice.Proprietary)
    )]
    [IsoId("_0kRD0wlIEeGATtfOBToyew_-1608397818")]
    [DisplayName("Rejection Reason 11 Choice")]
    public abstract record RejectionReason11Choice_ { }
}
