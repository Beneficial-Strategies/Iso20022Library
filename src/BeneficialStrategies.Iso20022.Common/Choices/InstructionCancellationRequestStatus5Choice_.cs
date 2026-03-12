// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus5Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.Accepted),nameof(InstructionCancellationRequestStatus5Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.Rejected),nameof(InstructionCancellationRequestStatus5Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus5Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus5Choice.ProprietaryStatus))]
    [IsoId("_lFNFUQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Instruction Cancellation Request Status 5 Choice")]
    public abstract partial record InstructionCancellationRequestStatus5Choice_
    {
    }
}
