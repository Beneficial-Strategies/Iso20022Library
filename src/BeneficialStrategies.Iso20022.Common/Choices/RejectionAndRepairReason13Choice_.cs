// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason13Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason13Choice.Code),
        nameof(RejectionAndRepairReason13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason13Choice.Proprietary),
        nameof(RejectionAndRepairReason13Choice.Proprietary)
    )]
    [IsoId("_OJVuX_4vEeClUvPNHKL9Zw")]
    [DisplayName("Rejection And Repair Reason 13 Choice")]
    public abstract record RejectionAndRepairReason13Choice_ { }
}
