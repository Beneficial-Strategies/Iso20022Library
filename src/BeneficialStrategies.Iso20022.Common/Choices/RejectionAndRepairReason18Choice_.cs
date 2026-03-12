// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason18Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason18Choice.Code),nameof(RejectionAndRepairReason18Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason18Choice.Proprietary),nameof(RejectionAndRepairReason18Choice.Proprietary))]
    [IsoId("__j39g0NHEeGHJ_bHJRPaIQ_80971047")]
    [DisplayName("Rejection And Repair Reason 18 Choice")]
    public abstract partial record RejectionAndRepairReason18Choice_
    {
    }
}
