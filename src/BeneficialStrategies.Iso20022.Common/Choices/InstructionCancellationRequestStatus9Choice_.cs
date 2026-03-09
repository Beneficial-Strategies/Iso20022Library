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
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus9Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.Accepted),nameof(InstructionCancellationRequestStatus9Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.Rejected),nameof(InstructionCancellationRequestStatus9Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus9Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus))]
    #endif
    [IsoId("_8eSfIUGWEeWqy4niLuXETA")]
    [DisplayName("Instruction Cancellation Request Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus9Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus9Choice_
    #endif
    {
    }
}
