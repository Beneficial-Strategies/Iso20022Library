// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason44Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason44Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason44Choice.Code),
        nameof(RejectionAndRepairReason44Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason44Choice.Proprietary),
        nameof(RejectionAndRepairReason44Choice.Proprietary)
    )]
    [IsoId("_gBIbVzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 44 Choice")]
    public abstract record RejectionAndRepairReason44Choice_ { }
}
