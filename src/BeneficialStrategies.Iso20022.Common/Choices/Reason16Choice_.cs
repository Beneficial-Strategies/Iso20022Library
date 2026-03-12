// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason16Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason16Choice.CancellationReason))]
    [KnownType(typeof(Reason16Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason16Choice.GeneratedReason))]
    [KnownType(typeof(Reason16Choice.DeniedReason))]
    [KnownType(typeof(Reason16Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason16Choice.PendingReason))]
    [KnownType(typeof(Reason16Choice.FailingReason))]
    [KnownType(typeof(Reason16Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason16Choice.RejectionReason))]
    [KnownType(typeof(Reason16Choice.RepairReason))]
    [KnownType(typeof(Reason16Choice.PendingModificationReason))]
    [KnownType(typeof(Reason16Choice.UnmatchedReason))]
    [JsonDerivedType(typeof(Reason16Choice.RepoCallAcknowledgementReason),nameof(Reason16Choice.RepoCallAcknowledgementReason))]
    [JsonDerivedType(typeof(Reason16Choice.CancellationReason),nameof(Reason16Choice.CancellationReason))]
    [JsonDerivedType(typeof(Reason16Choice.PendingCancellationReason),nameof(Reason16Choice.PendingCancellationReason))]
    [JsonDerivedType(typeof(Reason16Choice.GeneratedReason),nameof(Reason16Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason16Choice.DeniedReason),nameof(Reason16Choice.DeniedReason))]
    [JsonDerivedType(typeof(Reason16Choice.AcknowledgedAcceptedReason),nameof(Reason16Choice.AcknowledgedAcceptedReason))]
    [JsonDerivedType(typeof(Reason16Choice.PendingReason),nameof(Reason16Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason16Choice.FailingReason),nameof(Reason16Choice.FailingReason))]
    [JsonDerivedType(typeof(Reason16Choice.PendingProcessingReason),nameof(Reason16Choice.PendingProcessingReason))]
    [JsonDerivedType(typeof(Reason16Choice.RejectionReason),nameof(Reason16Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason16Choice.RepairReason),nameof(Reason16Choice.RepairReason))]
    [JsonDerivedType(typeof(Reason16Choice.PendingModificationReason),nameof(Reason16Choice.PendingModificationReason))]
    [JsonDerivedType(typeof(Reason16Choice.UnmatchedReason),nameof(Reason16Choice.UnmatchedReason))]
    [IsoId("_j3rg_TnvEeWfSKvvZlhRKg")]
    [DisplayName("Reason 16 Choice")]
    public abstract partial record Reason16Choice_
    {
    }
}
