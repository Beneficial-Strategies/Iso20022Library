// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.AcknowledgedAccepted),nameof(ModificationProcessingStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.PendingProcessing),nameof(ModificationProcessingStatus2Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Denied),nameof(ModificationProcessingStatus2Choice.Denied))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Rejected),nameof(ModificationProcessingStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Repaired),nameof(ModificationProcessingStatus2Choice.Repaired))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Modified),nameof(ModificationProcessingStatus2Choice.Modified))]
    [JsonDerivedType(typeof(ModificationProcessingStatus2Choice.Proprietary),nameof(ModificationProcessingStatus2Choice.Proprietary))]
    [IsoId("_0kkl1AlIEeGATtfOBToyew_205414048")]
    [DisplayName("Modification Processing Status 2 Choice")]
    public abstract partial record ModificationProcessingStatus2Choice_
    {
    }
}
