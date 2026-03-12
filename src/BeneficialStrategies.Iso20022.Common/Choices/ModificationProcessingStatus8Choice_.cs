// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus8Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus8Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.AcknowledgedAccepted),nameof(ModificationProcessingStatus8Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.PendingProcessing),nameof(ModificationProcessingStatus8Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.Denied),nameof(ModificationProcessingStatus8Choice.Denied))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.Rejected),nameof(ModificationProcessingStatus8Choice.Rejected))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.Repaired),nameof(ModificationProcessingStatus8Choice.Repaired))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.Modified),nameof(ModificationProcessingStatus8Choice.Modified))]
    [JsonDerivedType(typeof(ModificationProcessingStatus8Choice.Proprietary),nameof(ModificationProcessingStatus8Choice.Proprietary))]
    [IsoId("_6QCdM5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Processing Status 8 Choice")]
    public abstract partial record ModificationProcessingStatus8Choice_
    {
    }
}
