// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason32Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason32Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason32Choice.Code),
        nameof(RejectionAndRepairReason32Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason32Choice.Proprietary),
        nameof(RejectionAndRepairReason32Choice.Proprietary)
    )]
    [IsoId("_WplZoeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Rejection And Repair Reason 32 Choice")]
    public abstract record RejectionAndRepairReason32Choice_ { }
}
