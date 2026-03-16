// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason16Choice.Code))]
    [KnownType(typeof(RejectionReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason16Choice.Code), nameof(RejectionReason16Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason16Choice.Proprietary),
        nameof(RejectionReason16Choice.Proprietary)
    )]
    [IsoId("_DW4C4SwxEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Reason 16 Choice")]
    public abstract record RejectionReason16Choice_ { }
}
