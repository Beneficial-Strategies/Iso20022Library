// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason12Choice.Code))]
    [KnownType(typeof(PendingProcessingReason12Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingProcessingReason12Choice.Code),nameof(PendingProcessingReason12Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason12Choice.Proprietary),nameof(PendingProcessingReason12Choice.Proprietary))]
    [IsoId("_snJgkTq1EeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Reason 12 Choice")]
    public abstract partial record PendingProcessingReason12Choice_
    {
    }
}
