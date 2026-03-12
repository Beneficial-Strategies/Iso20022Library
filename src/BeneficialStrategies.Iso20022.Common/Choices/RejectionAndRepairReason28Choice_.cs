// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason28Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason28Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason28Choice.Code),nameof(RejectionAndRepairReason28Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason28Choice.Proprietary),nameof(RejectionAndRepairReason28Choice.Proprietary))]
    [IsoId("_6GXj5ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection And Repair Reason 28 Choice")]
    public abstract partial record RejectionAndRepairReason28Choice_
    {
    }
}
