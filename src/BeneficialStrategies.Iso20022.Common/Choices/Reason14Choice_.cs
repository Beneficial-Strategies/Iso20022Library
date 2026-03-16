// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason14Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason14Choice.CancellationReason))]
    [KnownType(typeof(Reason14Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason14Choice.GeneratedReason))]
    [KnownType(typeof(Reason14Choice.DeniedReason))]
    [KnownType(typeof(Reason14Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason14Choice.PendingReason))]
    [KnownType(typeof(Reason14Choice.FailingReason))]
    [KnownType(typeof(Reason14Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason14Choice.RejectionReason))]
    [KnownType(typeof(Reason14Choice.RepairReason))]
    [KnownType(typeof(Reason14Choice.PendingModificationReason))]
    [KnownType(typeof(Reason14Choice.UnmatchedReason))]
    [JsonDerivedType(
        typeof(Reason14Choice.RepoCallAcknowledgementReason),
        nameof(Reason14Choice.RepoCallAcknowledgementReason)
    )]
    [JsonDerivedType(
        typeof(Reason14Choice.CancellationReason),
        nameof(Reason14Choice.CancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason14Choice.PendingCancellationReason),
        nameof(Reason14Choice.PendingCancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason14Choice.GeneratedReason),
        nameof(Reason14Choice.GeneratedReason)
    )]
    [JsonDerivedType(typeof(Reason14Choice.DeniedReason), nameof(Reason14Choice.DeniedReason))]
    [JsonDerivedType(
        typeof(Reason14Choice.AcknowledgedAcceptedReason),
        nameof(Reason14Choice.AcknowledgedAcceptedReason)
    )]
    [JsonDerivedType(typeof(Reason14Choice.PendingReason), nameof(Reason14Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason14Choice.FailingReason), nameof(Reason14Choice.FailingReason))]
    [JsonDerivedType(
        typeof(Reason14Choice.PendingProcessingReason),
        nameof(Reason14Choice.PendingProcessingReason)
    )]
    [JsonDerivedType(
        typeof(Reason14Choice.RejectionReason),
        nameof(Reason14Choice.RejectionReason)
    )]
    [JsonDerivedType(typeof(Reason14Choice.RepairReason), nameof(Reason14Choice.RepairReason))]
    [JsonDerivedType(
        typeof(Reason14Choice.PendingModificationReason),
        nameof(Reason14Choice.PendingModificationReason)
    )]
    [JsonDerivedType(
        typeof(Reason14Choice.UnmatchedReason),
        nameof(Reason14Choice.UnmatchedReason)
    )]
    [IsoId("_uW-mvVhpEeS8HfHHd4stCA")]
    [DisplayName("Reason 14 Choice")]
    public abstract record Reason14Choice_ { }
}
