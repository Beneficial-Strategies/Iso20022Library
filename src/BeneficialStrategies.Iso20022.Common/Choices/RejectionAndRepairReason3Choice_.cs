// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason3Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason3Choice.Code),
        nameof(RejectionAndRepairReason3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason3Choice.Proprietary),
        nameof(RejectionAndRepairReason3Choice.Proprietary)
    )]
    [IsoId("_UWigd9p-Ed-ak6NoX_4Aeg_-1938373835")]
    [DisplayName("Rejection And Repair Reason 3 Choice")]
    public abstract record RejectionAndRepairReason3Choice_ { }
}
