// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus12Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus12Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus12Choice.Accepted),
        nameof(InstructionCancellationRequestStatus12Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus12Choice.Rejected),
        nameof(InstructionCancellationRequestStatus12Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus12Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus12Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus12Choice.ProprietaryStatus)
    )]
    [IsoId("_86aSnZwtEeazcsnODTksnQ")]
    [DisplayName("Instruction Cancellation Request Status 12 Choice")]
    public abstract record InstructionCancellationRequestStatus12Choice_ { }
}
