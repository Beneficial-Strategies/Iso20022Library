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
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus15Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.Accepted),nameof(InstructionCancellationRequestStatus15Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.Rejected),nameof(InstructionCancellationRequestStatus15Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus15Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus))]
    #endif
    [IsoId("_oK_ukTQXEe2o-K1dwNg8Gg")]
    [DisplayName("Instruction Cancellation Request Status 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus15Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus15Choice_
    #endif
    {
    }
}
