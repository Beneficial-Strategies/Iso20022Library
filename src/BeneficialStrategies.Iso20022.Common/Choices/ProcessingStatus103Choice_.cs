// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus103Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("6cd2b09c-4d4f-457a-ace8-963978257c7d")]
    [DisplayName("Processing Status 103 Choice")]
    [KnownType(typeof(ProcessingStatus103Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus103Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus103Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus103Choice.Repair))]
    [KnownType(typeof(ProcessingStatus103Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus103Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus103Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus103Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus103Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus103Choice.ModificationRequested))]
    public abstract record ProcessingStatus103Choice_
    {
    }
}
