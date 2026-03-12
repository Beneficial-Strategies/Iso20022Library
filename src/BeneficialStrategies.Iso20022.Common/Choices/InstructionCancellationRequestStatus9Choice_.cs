// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus9Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.Accepted),nameof(InstructionCancellationRequestStatus9Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.Rejected),nameof(InstructionCancellationRequestStatus9Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus9Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus9Choice.ProprietaryStatus))]
    [IsoId("_8eSfIUGWEeWqy4niLuXETA")]
    [DisplayName("Instruction Cancellation Request Status 9 Choice")]
    public abstract partial record InstructionCancellationRequestStatus9Choice_
    {
    }
}
