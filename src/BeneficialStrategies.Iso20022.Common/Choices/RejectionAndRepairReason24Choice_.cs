// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason24Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason24Choice.Code),nameof(RejectionAndRepairReason24Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason24Choice.Proprietary),nameof(RejectionAndRepairReason24Choice.Proprietary))]
    [IsoId("_V2KUszq4EeWyoP0PbocV1Q")]
    [DisplayName("Rejection And Repair Reason 24 Choice")]
    public abstract partial record RejectionAndRepairReason24Choice_
    {
    }
}
