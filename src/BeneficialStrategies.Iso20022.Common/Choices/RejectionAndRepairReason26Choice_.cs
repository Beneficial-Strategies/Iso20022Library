// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason26Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason26Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason26Choice.Code),nameof(RejectionAndRepairReason26Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason26Choice.Proprietary),nameof(RejectionAndRepairReason26Choice.Proprietary))]
    [IsoId("_zsG9YTs_EeWRTLSN0i0tng")]
    [DisplayName("Rejection And Repair Reason 26 Choice")]
    public abstract partial record RejectionAndRepairReason26Choice_
    {
    }
}
