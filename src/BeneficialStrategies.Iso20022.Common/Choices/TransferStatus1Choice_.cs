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
    /// Choice of statuses for the status of the transfer.
    /// </summary>
    [KnownType(typeof(TransferStatus1Choice.Status))]
    [KnownType(typeof(TransferStatus1Choice.PendingSettlement))]
    [KnownType(typeof(TransferStatus1Choice.Unmatched))]
    [KnownType(typeof(TransferStatus1Choice.InRepair))]
    [KnownType(typeof(TransferStatus1Choice.Rejected))]
    [KnownType(typeof(TransferStatus1Choice.FailedSettlement))]
    [KnownType(typeof(TransferStatus1Choice.Cancelled))]
    [KnownType(typeof(TransferStatus1Choice.Reversed))]
    [KnownType(typeof(TransferStatus1Choice.CancellationPending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransferStatus1Choice.Status),nameof(TransferStatus1Choice.Status))]
    [JsonDerivedType(typeof(TransferStatus1Choice.PendingSettlement),nameof(TransferStatus1Choice.PendingSettlement))]
    [JsonDerivedType(typeof(TransferStatus1Choice.Unmatched),nameof(TransferStatus1Choice.Unmatched))]
    [JsonDerivedType(typeof(TransferStatus1Choice.InRepair),nameof(TransferStatus1Choice.InRepair))]
    [JsonDerivedType(typeof(TransferStatus1Choice.Rejected),nameof(TransferStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(TransferStatus1Choice.FailedSettlement),nameof(TransferStatus1Choice.FailedSettlement))]
    [JsonDerivedType(typeof(TransferStatus1Choice.Cancelled),nameof(TransferStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(TransferStatus1Choice.Reversed),nameof(TransferStatus1Choice.Reversed))]
    [JsonDerivedType(typeof(TransferStatus1Choice.CancellationPending),nameof(TransferStatus1Choice.CancellationPending))]
    #endif
    [IsoId("_-S3TkRwjEeOIveEnnb_1-A")]
    [DisplayName("Transfer Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferStatus1Choice_
    #else
    public abstract partial class TransferStatus1Choice_
    #endif
    {
    }
}
