// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason12Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason12Choice.CancellationReason))]
    [KnownType(typeof(Reason12Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason12Choice.GeneratedReason))]
    [KnownType(typeof(Reason12Choice.DeniedReason))]
    [KnownType(typeof(Reason12Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason12Choice.PendingReason))]
    [KnownType(typeof(Reason12Choice.FailingReason))]
    [KnownType(typeof(Reason12Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason12Choice.RejectionReason))]
    [KnownType(typeof(Reason12Choice.RepairReason))]
    [KnownType(typeof(Reason12Choice.PendingModificationReason))]
    [KnownType(typeof(Reason12Choice.UnmatchedReason))]
    [JsonDerivedType(
        typeof(Reason12Choice.RepoCallAcknowledgementReason),
        nameof(Reason12Choice.RepoCallAcknowledgementReason)
    )]
    [JsonDerivedType(
        typeof(Reason12Choice.CancellationReason),
        nameof(Reason12Choice.CancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason12Choice.PendingCancellationReason),
        nameof(Reason12Choice.PendingCancellationReason)
    )]
    [JsonDerivedType(
        typeof(Reason12Choice.GeneratedReason),
        nameof(Reason12Choice.GeneratedReason)
    )]
    [JsonDerivedType(typeof(Reason12Choice.DeniedReason), nameof(Reason12Choice.DeniedReason))]
    [JsonDerivedType(
        typeof(Reason12Choice.AcknowledgedAcceptedReason),
        nameof(Reason12Choice.AcknowledgedAcceptedReason)
    )]
    [JsonDerivedType(typeof(Reason12Choice.PendingReason), nameof(Reason12Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason12Choice.FailingReason), nameof(Reason12Choice.FailingReason))]
    [JsonDerivedType(
        typeof(Reason12Choice.PendingProcessingReason),
        nameof(Reason12Choice.PendingProcessingReason)
    )]
    [JsonDerivedType(
        typeof(Reason12Choice.RejectionReason),
        nameof(Reason12Choice.RejectionReason)
    )]
    [JsonDerivedType(typeof(Reason12Choice.RepairReason), nameof(Reason12Choice.RepairReason))]
    [JsonDerivedType(
        typeof(Reason12Choice.PendingModificationReason),
        nameof(Reason12Choice.PendingModificationReason)
    )]
    [JsonDerivedType(
        typeof(Reason12Choice.UnmatchedReason),
        nameof(Reason12Choice.UnmatchedReason)
    )]
    [IsoId("_CekpyyRhEeO8sskhVI3IDA")]
    [DisplayName("Reason 12 Choice")]
    public abstract record Reason12Choice_ { }
}
