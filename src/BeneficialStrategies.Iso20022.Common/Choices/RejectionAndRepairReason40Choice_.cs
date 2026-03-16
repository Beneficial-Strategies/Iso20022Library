// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason40Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason40Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason40Choice.Code),
        nameof(RejectionAndRepairReason40Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RejectionAndRepairReason40Choice.Proprietary),
        nameof(RejectionAndRepairReason40Choice.Proprietary)
    )]
    [IsoId("_cdk09zi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection And Repair Reason 40 Choice")]
    public abstract record RejectionAndRepairReason40Choice_ { }
}
