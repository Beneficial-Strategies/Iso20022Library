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
    [KnownType(typeof(InstructionCancellationRequestStatus7Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus7Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus7Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus7Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus7Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus7Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus7Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus7Choice.Accepted),nameof(InstructionCancellationRequestStatus7Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus7Choice.Rejected),nameof(InstructionCancellationRequestStatus7Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus7Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus7Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus7Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus7Choice.ProprietaryStatus))]
    #endif
    [IsoId("_NBsPQVhkEeSsH9MSoogb7Q")]
    [DisplayName("Instruction Cancellation Request Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus7Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus7Choice_
    #endif
    {
    }
}
