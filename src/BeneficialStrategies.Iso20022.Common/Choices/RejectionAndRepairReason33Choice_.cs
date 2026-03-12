// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason33Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason33Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason33Choice.Code),nameof(RejectionAndRepairReason33Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason33Choice.Proprietary),nameof(RejectionAndRepairReason33Choice.Proprietary))]
    [IsoId("_cPB4AeF8EeWCAvUNsZ5u6g")]
    [DisplayName("Rejection And Repair Reason 33 Choice")]
    public abstract partial record RejectionAndRepairReason33Choice_
    {
    }
}
