// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason30Choice.Code))]
    [KnownType(typeof(RejectionReason30Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason30Choice.Code), nameof(RejectionReason30Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason30Choice.Proprietary),
        nameof(RejectionReason30Choice.Proprietary)
    )]
    [IsoId("_6P-zhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 30 Choice")]
    public abstract record RejectionReason30Choice_ { }
}
