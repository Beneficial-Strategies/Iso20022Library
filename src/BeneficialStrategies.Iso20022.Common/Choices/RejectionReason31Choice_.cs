// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason31Choice.Code))]
    [KnownType(typeof(RejectionReason31Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason31Choice.Code), nameof(RejectionReason31Choice.Code))]
    [JsonDerivedType(
        typeof(RejectionReason31Choice.Proprietary),
        nameof(RejectionReason31Choice.Proprietary)
    )]
    [IsoId("_6QDEr5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Reason 31 Choice")]
    public abstract record RejectionReason31Choice_ { }
}
