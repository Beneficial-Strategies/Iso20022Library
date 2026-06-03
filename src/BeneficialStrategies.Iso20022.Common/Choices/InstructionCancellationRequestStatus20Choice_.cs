// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus20Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus20Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus20Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus20Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus20Choice.CancellationCompleted), nameof(InstructionCancellationRequestStatus20Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus20Choice.Rejected), nameof(InstructionCancellationRequestStatus20Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus20Choice.PendingCancellation), nameof(InstructionCancellationRequestStatus20Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus20Choice.ProprietaryStatus), nameof(InstructionCancellationRequestStatus20Choice.ProprietaryStatus))]
    [IsoId("_s9Gd5d8OEe-NrtAAlrBEgQ")]
    [DisplayName("Instruction Cancellation Request Status 20 Choice")]
    public abstract record InstructionCancellationRequestStatus20Choice_ { }
}
