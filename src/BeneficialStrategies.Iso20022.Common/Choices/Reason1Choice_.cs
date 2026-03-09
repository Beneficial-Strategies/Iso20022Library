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
    /// Choice of reason.
    /// </summary>
    [KnownType(typeof(Reason1Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason1Choice.CancellationReason))]
    [KnownType(typeof(Reason1Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason1Choice.GeneratedReason))]
    [KnownType(typeof(Reason1Choice.DeniedReason))]
    [KnownType(typeof(Reason1Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason1Choice.PendingReason))]
    [KnownType(typeof(Reason1Choice.FailingReason))]
    [KnownType(typeof(Reason1Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason1Choice.RejectionReason))]
    [KnownType(typeof(Reason1Choice.RepairReason))]
    [KnownType(typeof(Reason1Choice.PendingModificationReason))]
    [KnownType(typeof(Reason1Choice.UnmatchedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reason1Choice.RepoCallAcknowledgementReason),nameof(Reason1Choice.RepoCallAcknowledgementReason))]
    [JsonDerivedType(typeof(Reason1Choice.CancellationReason),nameof(Reason1Choice.CancellationReason))]
    [JsonDerivedType(typeof(Reason1Choice.PendingCancellationReason),nameof(Reason1Choice.PendingCancellationReason))]
    [JsonDerivedType(typeof(Reason1Choice.GeneratedReason),nameof(Reason1Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason1Choice.DeniedReason),nameof(Reason1Choice.DeniedReason))]
    [JsonDerivedType(typeof(Reason1Choice.AcknowledgedAcceptedReason),nameof(Reason1Choice.AcknowledgedAcceptedReason))]
    [JsonDerivedType(typeof(Reason1Choice.PendingReason),nameof(Reason1Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason1Choice.FailingReason),nameof(Reason1Choice.FailingReason))]
    [JsonDerivedType(typeof(Reason1Choice.PendingProcessingReason),nameof(Reason1Choice.PendingProcessingReason))]
    [JsonDerivedType(typeof(Reason1Choice.RejectionReason),nameof(Reason1Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason1Choice.RepairReason),nameof(Reason1Choice.RepairReason))]
    [JsonDerivedType(typeof(Reason1Choice.PendingModificationReason),nameof(Reason1Choice.PendingModificationReason))]
    [JsonDerivedType(typeof(Reason1Choice.UnmatchedReason),nameof(Reason1Choice.UnmatchedReason))]
    #endif
    [IsoId("_UXb4U9p-Ed-ak6NoX_4Aeg_1692385622")]
    [DisplayName("Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reason1Choice_
    #else
    public abstract partial class Reason1Choice_
    #endif
    {
    }
}
