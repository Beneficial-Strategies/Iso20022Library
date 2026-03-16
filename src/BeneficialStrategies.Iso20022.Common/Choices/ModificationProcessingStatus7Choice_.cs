// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.AcknowledgedAccepted),
        nameof(ModificationProcessingStatus7Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.PendingProcessing),
        nameof(ModificationProcessingStatus7Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.Denied),
        nameof(ModificationProcessingStatus7Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.Rejected),
        nameof(ModificationProcessingStatus7Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.Repaired),
        nameof(ModificationProcessingStatus7Choice.Repaired)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.Modified),
        nameof(ModificationProcessingStatus7Choice.Modified)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus7Choice.Proprietary),
        nameof(ModificationProcessingStatus7Choice.Proprietary)
    )]
    [IsoId("_1bR8UTp4EeWVrPy0StzzSg")]
    [DisplayName("Modification Processing Status 7 Choice")]
    public abstract record ModificationProcessingStatus7Choice_ { }
}
