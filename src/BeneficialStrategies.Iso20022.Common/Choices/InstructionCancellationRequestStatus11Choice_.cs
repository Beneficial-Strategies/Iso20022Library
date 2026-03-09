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
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus11Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.Accepted),nameof(InstructionCancellationRequestStatus11Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.Rejected),nameof(InstructionCancellationRequestStatus11Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus11Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus))]
    #endif
    [IsoId("_1OEe8YluEeavwKddCbm3hg")]
    [DisplayName("Instruction Cancellation Request Status 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus11Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus11Choice_
    #endif
    {
    }
}
