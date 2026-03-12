// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason6Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason6Choice.CancellationReason))]
    [KnownType(typeof(Reason6Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason6Choice.GeneratedReason))]
    [KnownType(typeof(Reason6Choice.DeniedReason))]
    [KnownType(typeof(Reason6Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason6Choice.PendingReason))]
    [KnownType(typeof(Reason6Choice.FailingReason))]
    [KnownType(typeof(Reason6Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason6Choice.RejectionReason))]
    [KnownType(typeof(Reason6Choice.RepairReason))]
    [KnownType(typeof(Reason6Choice.PendingModificationReason))]
    [KnownType(typeof(Reason6Choice.UnmatchedReason))]
    [JsonDerivedType(typeof(Reason6Choice.RepoCallAcknowledgementReason),nameof(Reason6Choice.RepoCallAcknowledgementReason))]
    [JsonDerivedType(typeof(Reason6Choice.CancellationReason),nameof(Reason6Choice.CancellationReason))]
    [JsonDerivedType(typeof(Reason6Choice.PendingCancellationReason),nameof(Reason6Choice.PendingCancellationReason))]
    [JsonDerivedType(typeof(Reason6Choice.GeneratedReason),nameof(Reason6Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason6Choice.DeniedReason),nameof(Reason6Choice.DeniedReason))]
    [JsonDerivedType(typeof(Reason6Choice.AcknowledgedAcceptedReason),nameof(Reason6Choice.AcknowledgedAcceptedReason))]
    [JsonDerivedType(typeof(Reason6Choice.PendingReason),nameof(Reason6Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason6Choice.FailingReason),nameof(Reason6Choice.FailingReason))]
    [JsonDerivedType(typeof(Reason6Choice.PendingProcessingReason),nameof(Reason6Choice.PendingProcessingReason))]
    [JsonDerivedType(typeof(Reason6Choice.RejectionReason),nameof(Reason6Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason6Choice.RepairReason),nameof(Reason6Choice.RepairReason))]
    [JsonDerivedType(typeof(Reason6Choice.PendingModificationReason),nameof(Reason6Choice.PendingModificationReason))]
    [JsonDerivedType(typeof(Reason6Choice.UnmatchedReason),nameof(Reason6Choice.UnmatchedReason))]
    [IsoId("_is3dwUAAEeCaq78Ig8ATcA")]
    [DisplayName("Reason 6 Choice")]
    public abstract partial record Reason6Choice_
    {
    }
}
