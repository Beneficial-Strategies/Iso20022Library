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
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus10Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus10Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus10Choice.Accepted),nameof(InstructionCancellationRequestStatus10Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus10Choice.Rejected),nameof(InstructionCancellationRequestStatus10Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus10Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus10Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus))]
    #endif
    [IsoId("_ce-5q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Cancellation Request Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus10Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus10Choice_
    #endif
    {
    }
}
