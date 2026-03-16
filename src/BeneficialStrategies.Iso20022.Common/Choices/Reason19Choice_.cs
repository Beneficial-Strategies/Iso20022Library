// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason19Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason19Choice.CancellationReason))]
    [KnownType(typeof(Reason19Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason19Choice.GeneratedReason))]
    [KnownType(typeof(Reason19Choice.DeniedReason))]
    [KnownType(typeof(Reason19Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason19Choice.PendingReason))]
    [KnownType(typeof(Reason19Choice.FailingReason))]
    [KnownType(typeof(Reason19Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason19Choice.RejectionReason))]
    [KnownType(typeof(Reason19Choice.RepairReason))]
    [KnownType(typeof(Reason19Choice.PendingModificationReason))]
    [KnownType(typeof(Reason19Choice.UnmatchedReason))]
    [JsonDerivedType(
        typeof(Reason19Choice.RepoCallAcknowledgementReason),
        nameof(Reason19Choice.RepoCallAcknowledgementReason)
    )]
    [JsonDerivedType(
        typeof(Reason19Choice.CancellationReason),
        nameof(Reason19Choice.CancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason19Choice.PendingCancellationReason),
        nameof(Reason19Choice.PendingCancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason19Choice.GeneratedReason),
        nameof(Reason19Choice.GeneratedReason)
    )]
    [JsonDerivedType(typeof(Reason19Choice.DeniedReason), nameof(Reason19Choice.DeniedReason))]
    [JsonDerivedType(
        typeof(Reason19Choice.AcknowledgedAcceptedReason),
        nameof(Reason19Choice.AcknowledgedAcceptedReason)
    )]
    [JsonDerivedType(typeof(Reason19Choice.PendingReason), nameof(Reason19Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason19Choice.FailingReason), nameof(Reason19Choice.FailingReason))]
    [JsonDerivedType(
        typeof(Reason19Choice.PendingProcessingReason),
        nameof(Reason19Choice.PendingProcessingReason)
    )]
    [JsonDerivedType(
        typeof(Reason19Choice.RejectionReason),
        nameof(Reason19Choice.RejectionReason)
    )]
    [JsonDerivedType(typeof(Reason19Choice.RepairReason), nameof(Reason19Choice.RepairReason))]
    [JsonDerivedType(
        typeof(Reason19Choice.PendingModificationReason),
        nameof(Reason19Choice.PendingModificationReason)
    )]
    [JsonDerivedType(
        typeof(Reason19Choice.UnmatchedReason),
        nameof(Reason19Choice.UnmatchedReason)
    )]
    [IsoId("_70ByHStXEeyhipY4f42fZQ")]
    [DisplayName("Reason 19 Choice")]
    public abstract record Reason19Choice_ { }
}
