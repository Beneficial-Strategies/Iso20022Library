// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason2Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason2Choice.Code),
        nameof(RejectionAndRepairReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason2Choice.Proprietary),
        nameof(RejectionAndRepairReason2Choice.Proprietary)
    )]
    [IsoId("_UWrqYtp-Ed-ak6NoX_4Aeg_1498536988")]
    [DisplayName("Rejection And Repair Reason 2 Choice")]
    public abstract record RejectionAndRepairReason2Choice_ { }
}
