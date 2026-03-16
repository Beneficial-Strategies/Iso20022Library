// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason18Choice.Code))]
    [KnownType(typeof(PendingProcessingReason18Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason18Choice.Code),
        nameof(PendingProcessingReason18Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason18Choice.Proprietary),
        nameof(PendingProcessingReason18Choice.Proprietary)
    )]
    [IsoId("_qTGQiSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Processing Reason 18 Choice")]
    public abstract record PendingProcessingReason18Choice_ { }
}
