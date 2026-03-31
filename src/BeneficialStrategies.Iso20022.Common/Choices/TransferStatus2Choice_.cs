// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of statuses for the status of the transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus2Choice.Status))]
    [KnownType(typeof(TransferStatus2Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus2Choice.Unmatched))]
    [KnownType(typeof(TransferStatus2Choice.InRepair))]
    [KnownType(typeof(TransferStatus2Choice.Rejected))]
    [KnownType(typeof(TransferStatus2Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus2Choice.Cancelled))]
    [KnownType(typeof(TransferStatus2Choice.Reversed))]
    [KnownType(typeof(TransferStatus2Choice.CancellationPending))]
    [JsonDerivedType(typeof(TransferStatus2Choice.Status), nameof(TransferStatus2Choice.Status))]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.PendingSettlement),
        nameof(TransferStatus2Choice.PendingSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.Unmatched),
        nameof(TransferStatus2Choice.Unmatched)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.InRepair),
        nameof(TransferStatus2Choice.InRepair)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.Rejected),
        nameof(TransferStatus2Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.FailedSettlement),
        nameof(TransferStatus2Choice.FailedSettlement)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.Cancelled),
        nameof(TransferStatus2Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.Reversed),
        nameof(TransferStatus2Choice.Reversed)
    )]
    [JsonDerivedType(
        typeof(TransferStatus2Choice.CancellationPending),
        nameof(TransferStatus2Choice.CancellationPending)
    )]
    [IsoId("_Z0aGASY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Transfer Status 2 Choice")]
    public abstract record TransferStatus2Choice_ { }
}
