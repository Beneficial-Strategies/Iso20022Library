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
    [KnownType(typeof(InstructionCancellationRequestStatus3Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus3Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus3Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus3Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus3Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus3Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus3Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus3Choice.Accepted),nameof(InstructionCancellationRequestStatus3Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus3Choice.Rejected),nameof(InstructionCancellationRequestStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus3Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus3Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus3Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus3Choice.ProprietaryStatus))]
    #endif
    [IsoId("_V4EH4eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Instruction Cancellation Request Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus3Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus3Choice_
    #endif
    {
    }
}
