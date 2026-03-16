// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus10Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus10Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus10Choice.Accepted),
        nameof(InstructionCancellationRequestStatus10Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus10Choice.Rejected),
        nameof(InstructionCancellationRequestStatus10Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus10Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus10Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus10Choice.ProprietaryStatus)
    )]
    [IsoId("_ce-5q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Cancellation Request Status 10 Choice")]
    public abstract record InstructionCancellationRequestStatus10Choice_ { }
}
