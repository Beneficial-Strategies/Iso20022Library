// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus7Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus7Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus7Choice.Accepted),
        nameof(InstructionCancellationRequestStatus7Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus7Choice.Rejected),
        nameof(InstructionCancellationRequestStatus7Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus7Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus7Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus7Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus7Choice.ProprietaryStatus)
    )]
    [IsoId("_NBsPQVhkEeSsH9MSoogb7Q")]
    [DisplayName("Instruction Cancellation Request Status 7 Choice")]
    public abstract record InstructionCancellationRequestStatus7Choice_ { }
}
