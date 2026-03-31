// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason11Choice.Code))]
    [KnownType(typeof(PendingProcessingReason11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason11Choice.Code),
        nameof(PendingProcessingReason11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason11Choice.Proprietary),
        nameof(PendingProcessingReason11Choice.Proprietary)
    )]
    [IsoId("_DVNwsTqyEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Reason 11 Choice")]
    public abstract record PendingProcessingReason11Choice_ { }
}
