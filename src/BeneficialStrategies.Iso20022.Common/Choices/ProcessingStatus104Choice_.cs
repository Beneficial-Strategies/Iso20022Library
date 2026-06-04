// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus104Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("74e10bf2-f4ce-430d-95ac-f225c2d8c767")]
    [DisplayName("Processing Status 104 Choice")]
    [KnownType(typeof(ProcessingStatus104Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus104Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus104Choice.Repair))]
    [KnownType(typeof(ProcessingStatus104Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus104Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus104Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus104Choice.CancellationRequested))]
    public abstract record ProcessingStatus104Choice_
    {
    }
}
