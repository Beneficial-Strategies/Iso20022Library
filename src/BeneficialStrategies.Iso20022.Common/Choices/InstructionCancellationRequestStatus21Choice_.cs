// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus21Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus21Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus21Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus21Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus21Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus21Choice.CancellationCompleted), nameof(InstructionCancellationRequestStatus21Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus21Choice.Accepted), nameof(InstructionCancellationRequestStatus21Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus21Choice.Rejected), nameof(InstructionCancellationRequestStatus21Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus21Choice.PendingCancellation), nameof(InstructionCancellationRequestStatus21Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus21Choice.ProprietaryStatus), nameof(InstructionCancellationRequestStatus21Choice.ProprietaryStatus))]
    [IsoId("_c2C24aKvEfCHi7w3_0pcpw")]
    [DisplayName("Instruction Cancellation Request Status 21 Choice")]
    public abstract record InstructionCancellationRequestStatus21Choice_ { }
}
