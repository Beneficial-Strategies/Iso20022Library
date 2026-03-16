// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason29Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason29Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason29Choice.Code),
        nameof(RejectionAndRepairReason29Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason29Choice.Proprietary),
        nameof(RejectionAndRepairReason29Choice.Proprietary)
    )]
    [IsoId("_6QESuZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection And Repair Reason 29 Choice")]
    public abstract record RejectionAndRepairReason29Choice_ { }
}
