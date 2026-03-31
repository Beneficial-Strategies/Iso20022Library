// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of statuses for the status of a transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus4Choice.Status))]
    [KnownType(typeof(TransferStatus4Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus4Choice.Unmatched))]
    [KnownType(typeof(TransferStatus4Choice.InRepair))]
    [KnownType(typeof(TransferStatus4Choice.Rejected))]
    [KnownType(typeof(TransferStatus4Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus4Choice.Cancelled))]
    [KnownType(typeof(TransferStatus4Choice.Reversed))]
    [KnownType(typeof(TransferStatus4Choice.CancellationPending))]
    [JsonDerivedType(typeof(TransferStatus4Choice.Status), nameof(TransferStatus4Choice.Status))]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.PendingSettlement),
        nameof(TransferStatus4Choice.PendingSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.Unmatched),
        nameof(TransferStatus4Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.InRepair),
        nameof(TransferStatus4Choice.InRepair)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.Rejected),
        nameof(TransferStatus4Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.FailedSettlement),
        nameof(TransferStatus4Choice.FailedSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.Cancelled),
        nameof(TransferStatus4Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.Reversed),
        nameof(TransferStatus4Choice.Reversed)
    )]
    [JsonDerivedType(
        typeof(TransferStatus4Choice.CancellationPending),
        nameof(TransferStatus4Choice.CancellationPending)
    )]
    [IsoId("_fTIFwZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Status 4 Choice")]
    public abstract record TransferStatus4Choice_ { }
}
