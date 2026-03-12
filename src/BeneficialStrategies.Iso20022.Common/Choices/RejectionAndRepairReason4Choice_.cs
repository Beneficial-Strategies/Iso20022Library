// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason4Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason4Choice.Code),nameof(RejectionAndRepairReason4Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason4Choice.Proprietary),nameof(RejectionAndRepairReason4Choice.Proprietary))]
    [IsoId("_UWrqaNp-Ed-ak6NoX_4Aeg_-1811454224")]
    [DisplayName("Rejection And Repair Reason 4 Choice")]
    public abstract partial record RejectionAndRepairReason4Choice_
    {
    }
}
