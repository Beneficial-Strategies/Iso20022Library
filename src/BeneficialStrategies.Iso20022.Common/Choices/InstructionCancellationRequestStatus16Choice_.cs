// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus16Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus16Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus16Choice.Accepted),
        nameof(InstructionCancellationRequestStatus16Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus16Choice.Rejected),
        nameof(InstructionCancellationRequestStatus16Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus16Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus16Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus16Choice.ProprietaryStatus)
    )]
    [IsoId("_NpuVsl99Ee262vCSVgjImg")]
    [DisplayName("Instruction Cancellation Request Status 16 Choice")]
    public abstract record InstructionCancellationRequestStatus16Choice_ { }
}
