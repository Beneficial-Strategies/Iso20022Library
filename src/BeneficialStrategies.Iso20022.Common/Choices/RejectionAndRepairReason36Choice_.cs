// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason36Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason36Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason36Choice.Code),nameof(RejectionAndRepairReason36Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason36Choice.Proprietary),nameof(RejectionAndRepairReason36Choice.Proprietary))]
    [IsoId("_aWRJQStUEeyhipY4f42fZQ")]
    [DisplayName("Rejection And Repair Reason 36 Choice")]
    public abstract partial record RejectionAndRepairReason36Choice_
    {
    }
}
