// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus32Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus32Choice.Uncovered))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Accepted),
        nameof(InstructionProcessingStatus32Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Cancelled),
        nameof(InstructionProcessingStatus32Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus32Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Rejected),
        nameof(InstructionProcessingStatus32Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Pending),
        nameof(InstructionProcessingStatus32Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.PendingCancellation),
        nameof(InstructionProcessingStatus32Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Covered),
        nameof(InstructionProcessingStatus32Choice.Covered)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus32Choice.Uncovered),
        nameof(InstructionProcessingStatus32Choice.Uncovered)
    )]
    [IsoId("_BfFN_rtTEeilsanBGAzy4A")]
    [DisplayName("Instruction Processing Status 32 Choice")]
    public abstract record InstructionProcessingStatus32Choice_ { }
}
