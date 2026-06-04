// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus102Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("d2333b15-2633-4ad9-ad8f-43404ff656b7")]
    [DisplayName("Processing Status 102 Choice")]
    [KnownType(typeof(ProcessingStatus102Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus102Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus102Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus102Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus102Choice.Repair))]
    [KnownType(typeof(ProcessingStatus102Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus102Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus102Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus102Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus102Choice.ModificationRequested))]
    public abstract record ProcessingStatus102Choice_
    {
    }
}
