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
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus1Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.Accepted),nameof(InstructionCancellationRequestStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.Rejected),nameof(InstructionCancellationRequestStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus1Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus))]
    #endif
    [IsoId("_QyGwYtp-Ed-ak6NoX_4Aeg_-1849748214")]
    [DisplayName("Instruction Cancellation Request Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionCancellationRequestStatus1Choice_
    #else
    public abstract partial class InstructionCancellationRequestStatus1Choice_
    #endif
    {
    }
}
