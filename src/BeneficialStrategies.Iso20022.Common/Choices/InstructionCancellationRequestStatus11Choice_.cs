// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus11Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.Accepted),nameof(InstructionCancellationRequestStatus11Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.Rejected),nameof(InstructionCancellationRequestStatus11Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus11Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus11Choice.ProprietaryStatus))]
    [IsoId("_1OEe8YluEeavwKddCbm3hg")]
    [DisplayName("Instruction Cancellation Request Status 11 Choice")]
    public abstract partial record InstructionCancellationRequestStatus11Choice_
    {
    }
}
