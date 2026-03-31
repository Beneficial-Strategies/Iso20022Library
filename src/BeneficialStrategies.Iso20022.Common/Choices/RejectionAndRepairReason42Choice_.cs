// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason42Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason42Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason42Choice.Code),
        nameof(RejectionAndRepairReason42Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason42Choice.Proprietary),
        nameof(RejectionAndRepairReason42Choice.Proprietary)
    )]
    [IsoId("_ds1eGzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 42 Choice")]
    public abstract record RejectionAndRepairReason42Choice_ { }
}
