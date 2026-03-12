// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.CancellationCompleted))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.Accepted))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.Rejected))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.PendingCancellation))]
    [KnownType(typeof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.CancellationCompleted),nameof(InstructionCancellationRequestStatus1Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.Accepted),nameof(InstructionCancellationRequestStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.Rejected),nameof(InstructionCancellationRequestStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.PendingCancellation),nameof(InstructionCancellationRequestStatus1Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus),nameof(InstructionCancellationRequestStatus1Choice.ProprietaryStatus))]
    [IsoId("_QyGwYtp-Ed-ak6NoX_4Aeg_-1849748214")]
    [DisplayName("Instruction Cancellation Request Status 1 Choice")]
    public abstract partial record InstructionCancellationRequestStatus1Choice_
    {
    }
}
