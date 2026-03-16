// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason25Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason25Choice.Code),
        nameof(RejectionAndRepairReason25Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason25Choice.Proprietary),
        nameof(RejectionAndRepairReason25Choice.Proprietary)
    )]
    [IsoId("_osbQEzq4EeWyoP0PbocV1Q")]
    [DisplayName("Rejection And Repair Reason 25 Choice")]
    public abstract record RejectionAndRepairReason25Choice_ { }
}
