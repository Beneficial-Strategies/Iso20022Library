// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason7Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason7Choice.CancellationReason))]
    [KnownType(typeof(Reason7Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason7Choice.GeneratedReason))]
    [KnownType(typeof(Reason7Choice.DeniedReason))]
    [KnownType(typeof(Reason7Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason7Choice.PendingReason))]
    [KnownType(typeof(Reason7Choice.FailingReason))]
    [KnownType(typeof(Reason7Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason7Choice.RejectionReason))]
    [KnownType(typeof(Reason7Choice.RepairReason))]
    [KnownType(typeof(Reason7Choice.PendingModificationReason))]
    [KnownType(typeof(Reason7Choice.UnmatchedReason))]
    [JsonDerivedType(
        typeof(Reason7Choice.RepoCallAcknowledgementReason),
        nameof(Reason7Choice.RepoCallAcknowledgementReason)
    )]
    [JsonDerivedType(
        typeof(Reason7Choice.CancellationReason),
        nameof(Reason7Choice.CancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason7Choice.PendingCancellationReason),
        nameof(Reason7Choice.PendingCancellationReason)
    )]
    [JsonDerivedType(typeof(Reason7Choice.GeneratedReason), nameof(Reason7Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason7Choice.DeniedReason), nameof(Reason7Choice.DeniedReason))]
    [JsonDerivedType(
        typeof(Reason7Choice.AcknowledgedAcceptedReason),
        nameof(Reason7Choice.AcknowledgedAcceptedReason)
    )]
    [JsonDerivedType(typeof(Reason7Choice.PendingReason), nameof(Reason7Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason7Choice.FailingReason), nameof(Reason7Choice.FailingReason))]
    [JsonDerivedType(
        typeof(Reason7Choice.PendingProcessingReason),
        nameof(Reason7Choice.PendingProcessingReason)
    )]
    [JsonDerivedType(typeof(Reason7Choice.RejectionReason), nameof(Reason7Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason7Choice.RepairReason), nameof(Reason7Choice.RepairReason))]
    [JsonDerivedType(
        typeof(Reason7Choice.PendingModificationReason),
        nameof(Reason7Choice.PendingModificationReason)
    )]
    [JsonDerivedType(typeof(Reason7Choice.UnmatchedReason), nameof(Reason7Choice.UnmatchedReason))]
    [IsoId("_E2DtN_4hEeCH9dkaY_DhYw")]
    [DisplayName("Reason 7 Choice")]
    public abstract record Reason7Choice_ { }
}
