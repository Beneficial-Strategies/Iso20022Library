// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason10Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason10Choice.Code),nameof(RejectionAndRepairReason10Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason10Choice.Proprietary),nameof(RejectionAndRepairReason10Choice.Proprietary))]
    [IsoId("_QBkUQfI4Ed-dOvqmSLSz5g")]
    [DisplayName("Rejection And Repair Reason 10 Choice")]
    public abstract partial record RejectionAndRepairReason10Choice_
    {
    }
}
