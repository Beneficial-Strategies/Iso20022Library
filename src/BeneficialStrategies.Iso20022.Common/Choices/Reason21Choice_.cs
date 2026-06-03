// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Reason21Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between reason types for a transaction status.</summary>
    [IsoId("8a33d039-3d57-4ac9-831c-34e3c708a8c3")]
    [DisplayName("Reason 21 Choice")]
    [KnownType(typeof(Reason21Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason21Choice.CancellationReason))]
    [KnownType(typeof(Reason21Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason21Choice.GeneratedReason))]
    [KnownType(typeof(Reason21Choice.DeniedReason))]
    [KnownType(typeof(Reason21Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason21Choice.PendingReason))]
    [KnownType(typeof(Reason21Choice.FailingReason))]
    [KnownType(typeof(Reason21Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason21Choice.RejectionReason))]
    [KnownType(typeof(Reason21Choice.RepairReason))]
    [KnownType(typeof(Reason21Choice.PendingModificationReason))]
    [KnownType(typeof(Reason21Choice.UnmatchedReason))]
    [JsonDerivedType(typeof(Reason21Choice.RepoCallAcknowledgementReason))]
    [JsonDerivedType(typeof(Reason21Choice.CancellationReason))]
    [JsonDerivedType(typeof(Reason21Choice.PendingCancellationReason))]
    [JsonDerivedType(typeof(Reason21Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason21Choice.DeniedReason))]
    [JsonDerivedType(typeof(Reason21Choice.AcknowledgedAcceptedReason))]
    [JsonDerivedType(typeof(Reason21Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason21Choice.FailingReason))]
    [JsonDerivedType(typeof(Reason21Choice.PendingProcessingReason))]
    [JsonDerivedType(typeof(Reason21Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason21Choice.RepairReason))]
    [JsonDerivedType(typeof(Reason21Choice.PendingModificationReason))]
    [JsonDerivedType(typeof(Reason21Choice.UnmatchedReason))]
    public abstract record Reason21Choice_
    {
    }
}
