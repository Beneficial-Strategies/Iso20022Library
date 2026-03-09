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
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus5Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.Accepted),nameof(InstructionCancellationRequestStatus5Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.Rejected),nameof(InstructionCancellationRequestStatus5Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus5Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus))]
    #endif
    [IsoId("_lFNFUQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Instruction Cancellation Request Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus5Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus5Choice_
    #endif
    {
    }
}
