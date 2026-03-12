// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a pending status.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason8Choice.Code))]
    [KnownType(typeof(PendingProcessingReason8Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingProcessingReason8Choice.Code),nameof(PendingProcessingReason8Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason8Choice.Proprietary),nameof(PendingProcessingReason8Choice.Proprietary))]
    [IsoId("_OoypvljsEeOnqqBHs8Gasw")]
    [DisplayName("Pending Processing Reason 8 Choice")]
    public abstract partial record PendingProcessingReason8Choice_
    {
    }
}
