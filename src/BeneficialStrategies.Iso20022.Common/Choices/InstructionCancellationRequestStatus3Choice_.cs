// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus3Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus3Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus3Choice.Accepted),
        nameof(InstructionCancellationRequestStatus3Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus3Choice.Rejected),
        nameof(InstructionCancellationRequestStatus3Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus3Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus3Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus3Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus3Choice.ProprietaryStatus)
    )]
    [IsoId("_V4EH4eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Instruction Cancellation Request Status 3 Choice")]
    public abstract record InstructionCancellationRequestStatus3Choice_ { }
}
