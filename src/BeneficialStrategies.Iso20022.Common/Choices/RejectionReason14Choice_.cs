// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason14Choice.Code))]
    [KnownType(typeof(RejectionReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason14Choice.Code), nameof(RejectionReason14Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason14Choice.Proprietary),
        nameof(RejectionReason14Choice.Proprietary)
    )]
    [IsoId("_omJ5wSwtEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Reason 14 Choice")]
    public abstract record RejectionReason14Choice_ { }
}
