// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of statuses for the status of a transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus5Choice.Status))]
    [KnownType(typeof(TransferStatus5Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus5Choice.Unmatched))]
    [KnownType(typeof(TransferStatus5Choice.InRepair))]
    [KnownType(typeof(TransferStatus5Choice.Rejected))]
    [KnownType(typeof(TransferStatus5Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus5Choice.Cancelled))]
    [KnownType(typeof(TransferStatus5Choice.Reversed))]
    [KnownType(typeof(TransferStatus5Choice.CancellationPending))]
    [JsonDerivedType(typeof(TransferStatus5Choice.Status), nameof(TransferStatus5Choice.Status))]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.PendingSettlement),
        nameof(TransferStatus5Choice.PendingSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.Unmatched),
        nameof(TransferStatus5Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.InRepair),
        nameof(TransferStatus5Choice.InRepair)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.Rejected),
        nameof(TransferStatus5Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.FailedSettlement),
        nameof(TransferStatus5Choice.FailedSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.Cancelled),
        nameof(TransferStatus5Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.Reversed),
        nameof(TransferStatus5Choice.Reversed)
    )]
    [JsonDerivedType(
        typeof(TransferStatus5Choice.CancellationPending),
        nameof(TransferStatus5Choice.CancellationPending)
    )]
    [IsoId("_WDhzoeijEeuLe8v4JEtDDg")]
    [DisplayName("Transfer Status 5 Choice")]
    public abstract record TransferStatus5Choice_ { }
}
