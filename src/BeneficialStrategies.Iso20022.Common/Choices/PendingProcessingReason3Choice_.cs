// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason3Choice.Code))]
    [KnownType(typeof(PendingProcessingReason3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason3Choice.Code),
        nameof(PendingProcessingReason3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason3Choice.Proprietary),
        nameof(PendingProcessingReason3Choice.Proprietary)
    )]
    [IsoId("_sJQsSf8dEeCrw_OT0uBMXQ")]
    [DisplayName("Pending Processing Reason 3 Choice")]
    public abstract record PendingProcessingReason3Choice_ { }
}
