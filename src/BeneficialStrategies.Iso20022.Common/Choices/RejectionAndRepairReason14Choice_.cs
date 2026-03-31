// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason14Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason14Choice.Code),
        nameof(RejectionAndRepairReason14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason14Choice.Proprietary),
        nameof(RejectionAndRepairReason14Choice.Proprietary)
    )]
    [IsoId("_ify0V_4wEeClUvPNHKL9Zw")]
    [DisplayName("Rejection And Repair Reason 14 Choice")]
    public abstract record RejectionAndRepairReason14Choice_ { }
}
