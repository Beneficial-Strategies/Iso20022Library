// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason39Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason39Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason39Choice.Code),nameof(RejectionAndRepairReason39Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason39Choice.Proprietary),nameof(RejectionAndRepairReason39Choice.Proprietary))]
    [IsoId("_TP_tUStYEeyhipY4f42fZQ")]
    [DisplayName("Rejection And Repair Reason 39 Choice")]
    public abstract partial record RejectionAndRepairReason39Choice_
    {
    }
}
