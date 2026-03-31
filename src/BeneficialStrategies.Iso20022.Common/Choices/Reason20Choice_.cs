// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason20Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason20Choice.CancellationReason))]
    [KnownType(typeof(Reason20Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason20Choice.GeneratedReason))]
    [KnownType(typeof(Reason20Choice.DeniedReason))]
    [KnownType(typeof(Reason20Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason20Choice.PendingReason))]
    [KnownType(typeof(Reason20Choice.FailingReason))]
    [KnownType(typeof(Reason20Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason20Choice.RejectionReason))]
    [KnownType(typeof(Reason20Choice.RepairReason))]
    [KnownType(typeof(Reason20Choice.PendingModificationReason))]
    [KnownType(typeof(Reason20Choice.UnmatchedReason))]
    [JsonDerivedType(
        typeof(Reason20Choice.RepoCallAcknowledgementReason),
        nameof(Reason20Choice.RepoCallAcknowledgementReason)
    )]
    [JsonDerivedType(
        typeof(Reason20Choice.CancellationReason),
        nameof(Reason20Choice.CancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason20Choice.PendingCancellationReason),
        nameof(Reason20Choice.PendingCancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason20Choice.GeneratedReason),
        nameof(Reason20Choice.GeneratedReason)
    )]
    [JsonDerivedType(typeof(Reason20Choice.DeniedReason), nameof(Reason20Choice.DeniedReason))]
    [JsonDerivedType(
        typeof(Reason20Choice.AcknowledgedAcceptedReason),
        nameof(Reason20Choice.AcknowledgedAcceptedReason)
    )]
    [JsonDerivedType(typeof(Reason20Choice.PendingReason), nameof(Reason20Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason20Choice.FailingReason), nameof(Reason20Choice.FailingReason))]
    [JsonDerivedType(
        typeof(Reason20Choice.PendingProcessingReason),
        nameof(Reason20Choice.PendingProcessingReason)
    )]
    [JsonDerivedType(
        typeof(Reason20Choice.RejectionReason),
        nameof(Reason20Choice.RejectionReason)
    )]
    [JsonDerivedType(typeof(Reason20Choice.RepairReason), nameof(Reason20Choice.RepairReason))]
    [JsonDerivedType(
        typeof(Reason20Choice.PendingModificationReason),
        nameof(Reason20Choice.PendingModificationReason)
    )]
    [JsonDerivedType(
        typeof(Reason20Choice.UnmatchedReason),
        nameof(Reason20Choice.UnmatchedReason)
    )]
    [IsoId("_gAQ5fTi8Eeydid5dcNPKvg")]
    [DisplayName("Reason 20 Choice")]
    public abstract record Reason20Choice_ { }
}
