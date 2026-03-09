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
    [KnownType(typeof(Reason17Choice.RepoCallAcknowledgementReason))]
    [KnownType(typeof(Reason17Choice.CancellationReason))]
    [KnownType(typeof(Reason17Choice.PendingCancellationReason))]
    [KnownType(typeof(Reason17Choice.GeneratedReason))]
    [KnownType(typeof(Reason17Choice.DeniedReason))]
    [KnownType(typeof(Reason17Choice.AcknowledgedAcceptedReason))]
    [KnownType(typeof(Reason17Choice.PendingReason))]
    [KnownType(typeof(Reason17Choice.FailingReason))]
    [KnownType(typeof(Reason17Choice.PendingProcessingReason))]
    [KnownType(typeof(Reason17Choice.RejectionReason))]
    [KnownType(typeof(Reason17Choice.RepairReason))]
    [KnownType(typeof(Reason17Choice.PendingModificationReason))]
    [KnownType(typeof(Reason17Choice.UnmatchedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reason17Choice.RepoCallAcknowledgementReason),nameof(Reason17Choice.RepoCallAcknowledgementReason))]
    [JsonDerivedType(typeof(Reason17Choice.CancellationReason),nameof(Reason17Choice.CancellationReason))]
    [JsonDerivedType(typeof(Reason17Choice.PendingCancellationReason),nameof(Reason17Choice.PendingCancellationReason))]
    [JsonDerivedType(typeof(Reason17Choice.GeneratedReason),nameof(Reason17Choice.GeneratedReason))]
    [JsonDerivedType(typeof(Reason17Choice.DeniedReason),nameof(Reason17Choice.DeniedReason))]
    [JsonDerivedType(typeof(Reason17Choice.AcknowledgedAcceptedReason),nameof(Reason17Choice.AcknowledgedAcceptedReason))]
    [JsonDerivedType(typeof(Reason17Choice.PendingReason),nameof(Reason17Choice.PendingReason))]
    [JsonDerivedType(typeof(Reason17Choice.FailingReason),nameof(Reason17Choice.FailingReason))]
    [JsonDerivedType(typeof(Reason17Choice.PendingProcessingReason),nameof(Reason17Choice.PendingProcessingReason))]
    [JsonDerivedType(typeof(Reason17Choice.RejectionReason),nameof(Reason17Choice.RejectionReason))]
    [JsonDerivedType(typeof(Reason17Choice.RepairReason),nameof(Reason17Choice.RepairReason))]
    [JsonDerivedType(typeof(Reason17Choice.PendingModificationReason),nameof(Reason17Choice.PendingModificationReason))]
    [JsonDerivedType(typeof(Reason17Choice.UnmatchedReason),nameof(Reason17Choice.UnmatchedReason))]
    #endif
    [IsoId("_8Qc1z5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reason 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reason17Choice_
    #else
    public abstract partial class Reason17Choice_
    #endif
    {
    }
}
