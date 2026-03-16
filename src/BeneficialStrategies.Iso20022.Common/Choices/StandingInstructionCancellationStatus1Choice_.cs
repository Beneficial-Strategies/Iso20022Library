// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a standing instruction cancellation request.
    /// </summary>
    [KnownType(typeof(StandingInstructionCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(StandingInstructionCancellationStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(StandingInstructionCancellationStatus1Choice.ProcessedStatus),
        nameof(StandingInstructionCancellationStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(StandingInstructionCancellationStatus1Choice.RejectedStatus),
        nameof(StandingInstructionCancellationStatus1Choice.RejectedStatus)
    )]
    [IsoId("_RirRstp-Ed-ak6NoX_4Aeg_-1572447804")]
    [DisplayName("Standing Instruction Cancellation Status 1 Choice")]
    public abstract record StandingInstructionCancellationStatus1Choice_ { }
}
