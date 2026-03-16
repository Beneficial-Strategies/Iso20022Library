// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status53Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus53Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus53Choice.Uncovered))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Accepted),
        nameof(InstructionProcessingStatus53Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus53Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Cancelled),
        nameof(InstructionProcessingStatus53Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Covered),
        nameof(InstructionProcessingStatus53Choice.Covered)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Pending),
        nameof(InstructionProcessingStatus53Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.PendingCancellation),
        nameof(InstructionProcessingStatus53Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Rejected),
        nameof(InstructionProcessingStatus53Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus53Choice.Uncovered),
        nameof(InstructionProcessingStatus53Choice.Uncovered)
    )]
    [IsoId("_Uo1m53SdEe6VWZz2tTgENw")]
    [DisplayName("Instruction Processing Status53Choice")]
    public abstract record InstructionProcessingStatus53Choice_ { }
}
