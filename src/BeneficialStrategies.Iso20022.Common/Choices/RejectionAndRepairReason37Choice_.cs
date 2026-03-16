// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason37Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason37Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason37Choice.Code),
        nameof(RejectionAndRepairReason37Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason37Choice.Proprietary),
        nameof(RejectionAndRepairReason37Choice.Proprietary)
    )]
    [IsoId("_nOHI8ytVEeyhipY4f42fZQ")]
    [DisplayName("Rejection And Repair Reason 37 Choice")]
    public abstract record RejectionAndRepairReason37Choice_ { }
}
