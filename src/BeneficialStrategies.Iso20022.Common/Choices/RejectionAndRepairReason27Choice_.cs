// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason27Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason27Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason27Choice.Code),
        nameof(RejectionAndRepairReason27Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason27Choice.Proprietary),
        nameof(RejectionAndRepairReason27Choice.Proprietary)
    )]
    [IsoId("_5SFAmZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection And Repair Reason 27 Choice")]
    public abstract record RejectionAndRepairReason27Choice_ { }
}
