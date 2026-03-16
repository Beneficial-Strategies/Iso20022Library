// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason31Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason31Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason31Choice.Code),
        nameof(RejectionAndRepairReason31Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason31Choice.Proprietary),
        nameof(RejectionAndRepairReason31Choice.Proprietary)
    )]
    [IsoId("_8RtbW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection And Repair Reason 31 Choice")]
    public abstract record RejectionAndRepairReason31Choice_ { }
}
