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
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus16Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus16Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus16Choice.Accepted),nameof(InstructionCancellationRequestStatus16Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus16Choice.Rejected),nameof(InstructionCancellationRequestStatus16Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus16Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus16Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus))]
    #endif
    [IsoId("_NpuVsl99Ee262vCSVgjImg")]
    [DisplayName("Instruction Cancellation Request Status 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus16Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus16Choice_
    #endif
    {
    }
}
