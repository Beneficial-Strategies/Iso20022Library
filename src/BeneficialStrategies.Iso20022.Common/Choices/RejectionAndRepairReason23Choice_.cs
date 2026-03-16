// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason23Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason23Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason23Choice.Code),
        nameof(RejectionAndRepairReason23Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason23Choice.Proprietary),
        nameof(RejectionAndRepairReason23Choice.Proprietary)
    )]
    [IsoId("_KivHcTnuEeWfSKvvZlhRKg")]
    [DisplayName("Rejection And Repair Reason 23 Choice")]
    public abstract record RejectionAndRepairReason23Choice_ { }
}
