// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of statuses for the status of a transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus3Choice.Status))]
    [KnownType(typeof(TransferStatus3Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus3Choice.Unmatched))]
    [KnownType(typeof(TransferStatus3Choice.InRepair))]
    [KnownType(typeof(TransferStatus3Choice.Rejected))]
    [KnownType(typeof(TransferStatus3Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus3Choice.Cancelled))]
    [KnownType(typeof(TransferStatus3Choice.Reversed))]
    [KnownType(typeof(TransferStatus3Choice.CancellationPending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransferStatus3Choice.Status),nameof(TransferStatus3Choice.Status))]
    [JsonDerivedType(typeof(TransferStatus3Choice.PendingSettlement),nameof(TransferStatus3Choice.PendingSettlement))]
    [JsonDerivedType(typeof(TransferStatus3Choice.Unmatched),nameof(TransferStatus3Choice.Unmatched))]
    [JsonDerivedType(typeof(TransferStatus3Choice.InRepair),nameof(TransferStatus3Choice.InRepair))]
    [JsonDerivedType(typeof(TransferStatus3Choice.Rejected),nameof(TransferStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(TransferStatus3Choice.FailedSettlement),nameof(TransferStatus3Choice.FailedSettlement))]
    [JsonDerivedType(typeof(TransferStatus3Choice.Cancelled),nameof(TransferStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(TransferStatus3Choice.Reversed),nameof(TransferStatus3Choice.Reversed))]
    [JsonDerivedType(typeof(TransferStatus3Choice.CancellationPending),nameof(TransferStatus3Choice.CancellationPending))]
    #endif
    [IsoId("_aORxAVNUEeijdq8ilaxyOA")]
    [DisplayName("Transfer Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatus3Choice_
    #else
    public abstract partial class TransferStatus3Choice_
    #endif
    {
    }
}
