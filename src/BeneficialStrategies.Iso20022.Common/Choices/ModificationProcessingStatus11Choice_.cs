// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus11Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.AcknowledgedAccepted),
        nameof(ModificationProcessingStatus11Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.PendingProcessing),
        nameof(ModificationProcessingStatus11Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.Denied),
        nameof(ModificationProcessingStatus11Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.Rejected),
        nameof(ModificationProcessingStatus11Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.Repaired),
        nameof(ModificationProcessingStatus11Choice.Repaired)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.Modified),
        nameof(ModificationProcessingStatus11Choice.Modified)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus11Choice.Proprietary),
        nameof(ModificationProcessingStatus11Choice.Proprietary)
    )]
    [IsoId("_ds02HTi8Eeydid5dcNPKvg")]
    [DisplayName("Modification Processing Status 11 Choice")]
    public abstract record ModificationProcessingStatus11Choice_ { }
}
