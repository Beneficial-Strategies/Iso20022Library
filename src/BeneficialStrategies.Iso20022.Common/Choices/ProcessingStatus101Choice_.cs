// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus101Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats for a processing status.</summary>
    [IsoId("c1755382-36bd-4f5c-b4c0-64e7038637c9")]
    [DisplayName("Processing Status 101 Choice")]
    [KnownType(typeof(ProcessingStatus101Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus101Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus101Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus101Choice.Repair))]
    [KnownType(typeof(ProcessingStatus101Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus101Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus101Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus101Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus101Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus101Choice.ModificationRequested))]
    public abstract record ProcessingStatus101Choice_
    {
    }
}
