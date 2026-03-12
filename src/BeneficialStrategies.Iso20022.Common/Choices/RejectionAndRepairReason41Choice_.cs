// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason41Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason41Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason41Choice.Code),nameof(RejectionAndRepairReason41Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason41Choice.Proprietary),nameof(RejectionAndRepairReason41Choice.Proprietary))]
    [IsoId("_diXTqTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 41 Choice")]
    public abstract partial record RejectionAndRepairReason41Choice_
    {
    }
}
