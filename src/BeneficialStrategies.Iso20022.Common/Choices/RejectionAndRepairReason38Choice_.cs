// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason38Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason38Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason38Choice.Code),
        nameof(RejectionAndRepairReason38Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason38Choice.Proprietary),
        nameof(RejectionAndRepairReason38Choice.Proprietary)
    )]
    [IsoId("_ET1FcytXEeyhipY4f42fZQ")]
    [DisplayName("Rejection And Repair Reason 38 Choice")]
    public abstract record RejectionAndRepairReason38Choice_ { }
}
