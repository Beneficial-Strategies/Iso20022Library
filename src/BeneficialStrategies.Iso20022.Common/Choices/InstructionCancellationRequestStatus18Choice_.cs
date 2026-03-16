// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Cancellation Request Status18Choice.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus18Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus18Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus18Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus18Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionCancellationRequestStatus18Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus18Choice.Accepted),nameof(InstructionCancellationRequestStatus18Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus18Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus18Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus18Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus18Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus18Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus18Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus18Choice.Rejected),nameof(InstructionCancellationRequestStatus18Choice.Rejected))]
    [IsoId("_jhlJSZt3Ee-wQIOX0djF2w")]
    [DisplayName("Instruction Cancellation Request Status18Choice")]
    public abstract partial record InstructionCancellationRequestStatus18Choice_
    {
    }
}
