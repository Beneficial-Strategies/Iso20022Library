// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason10Choice.Code))]
    [KnownType(typeof(PendingProcessingReason10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason10Choice.Code),
        nameof(PendingProcessingReason10Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason10Choice.Proprietary),
        nameof(PendingProcessingReason10Choice.Proprietary)
    )]
    [IsoId("_MpK08TqdEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Reason 10 Choice")]
    public abstract record PendingProcessingReason10Choice_ { }
}
