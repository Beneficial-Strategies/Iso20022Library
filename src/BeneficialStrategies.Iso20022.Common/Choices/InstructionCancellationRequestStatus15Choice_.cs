// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus15Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.Accepted),nameof(InstructionCancellationRequestStatus15Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.Rejected),nameof(InstructionCancellationRequestStatus15Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus15Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus15Choice.ProprietaryStatus))]
    [IsoId("_oK_ukTQXEe2o-K1dwNg8Gg")]
    [DisplayName("Instruction Cancellation Request Status 15 Choice")]
    public abstract partial record InstructionCancellationRequestStatus15Choice_
    {
    }
}
