// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus13Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus13Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus13Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus13Choice.Accepted),nameof(InstructionCancellationRequestStatus13Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus13Choice.Rejected),nameof(InstructionCancellationRequestStatus13Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus13Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus13Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus13Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus13Choice.ProprietaryStatus))]
    [IsoId("_Vi6SERn0EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Cancellation Request Status 13 Choice")]
    public abstract partial record InstructionCancellationRequestStatus13Choice_
    {
    }
}
