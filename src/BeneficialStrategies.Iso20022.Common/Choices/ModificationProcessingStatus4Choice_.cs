// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus4Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.AcknowledgedAccepted),
        nameof(ModificationProcessingStatus4Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.PendingProcessing),
        nameof(ModificationProcessingStatus4Choice.PendingProcessing)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.Denied),
        nameof(ModificationProcessingStatus4Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.Rejected),
        nameof(ModificationProcessingStatus4Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.Repaired),
        nameof(ModificationProcessingStatus4Choice.Repaired)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.Modified),
        nameof(ModificationProcessingStatus4Choice.Modified)
    )]
    [JsonDerivedType(
        typeof(ModificationProcessingStatus4Choice.Proprietary),
        nameof(ModificationProcessingStatus4Choice.Proprietary)
    )]
    [IsoId("_gUOMsVhgEeS8HfHHd4stCA")]
    [DisplayName("Modification Processing Status 4 Choice")]
    public abstract record ModificationProcessingStatus4Choice_ { }
}
