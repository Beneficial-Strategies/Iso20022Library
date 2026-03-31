// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus14Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus14Choice.CancellationCompleted),
        nameof(InstructionCancellationRequestStatus14Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus14Choice.Accepted),
        nameof(InstructionCancellationRequestStatus14Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus14Choice.Rejected),
        nameof(InstructionCancellationRequestStatus14Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus14Choice.PendingCancellation),
        nameof(InstructionCancellationRequestStatus14Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionCancellationRequestStatus14Choice.ProprietaryStatus),
        nameof(InstructionCancellationRequestStatus14Choice.ProprietaryStatus)
    )]
    [IsoId("_peWYkzi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Cancellation Request Status 14 Choice")]
    public abstract record InstructionCancellationRequestStatus14Choice_ { }
}
