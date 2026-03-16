// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Cancellation Request Status17Choice.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus17Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus17Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus17Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus17Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionCancellationRequestStatus17Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus17Choice.Accepted),nameof(InstructionCancellationRequestStatus17Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus17Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus17Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus17Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus17Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus17Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus17Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus17Choice.Rejected),nameof(InstructionCancellationRequestStatus17Choice.Rejected))]
    [IsoId("_C1KMYYYREe-9jM3-w7OB3g")]
    [DisplayName("Instruction Cancellation Request Status17Choice")]
    public abstract partial record InstructionCancellationRequestStatus17Choice_
    {
    }
}
