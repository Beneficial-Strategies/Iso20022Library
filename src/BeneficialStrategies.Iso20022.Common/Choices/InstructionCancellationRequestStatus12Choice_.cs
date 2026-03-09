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
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus12Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus12Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus12Choice.Accepted),nameof(InstructionCancellationRequestStatus12Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus12Choice.Rejected),nameof(InstructionCancellationRequestStatus12Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus12Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus12Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus))]
    #endif
    [IsoId("_86aSnZwtEeazcsnODTksnQ")]
    [DisplayName("Instruction Cancellation Request Status 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus12Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus12Choice_
    #endif
    {
    }
}
