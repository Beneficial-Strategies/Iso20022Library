// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason34Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason34Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason34Choice.Code),nameof(RejectionAndRepairReason34Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason34Choice.Proprietary),nameof(RejectionAndRepairReason34Choice.Proprietary))]
    [IsoId("_m8KAseGKEeWCAvUNsZ5u6g")]
    [DisplayName("Rejection And Repair Reason 34 Choice")]
    public abstract partial record RejectionAndRepairReason34Choice_
    {
    }
}
