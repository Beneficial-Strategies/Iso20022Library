// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status57Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus57Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Returned))]
    [KnownType(typeof(InstructionProcessingStatus57Choice.Uncovered))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Accepted),
        nameof(InstructionProcessingStatus57Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus57Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Cancelled),
        nameof(InstructionProcessingStatus57Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Covered),
        nameof(InstructionProcessingStatus57Choice.Covered)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Pending),
        nameof(InstructionProcessingStatus57Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.PendingCancellation),
        nameof(InstructionProcessingStatus57Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Rejected),
        nameof(InstructionProcessingStatus57Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Returned),
        nameof(InstructionProcessingStatus57Choice.Returned)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus57Choice.Uncovered),
        nameof(InstructionProcessingStatus57Choice.Uncovered)
    )]
    [IsoId("_j2GAm5t3Ee-wQIOX0djF2w")]
    [DisplayName("Instruction Processing Status57Choice")]
    public abstract record InstructionProcessingStatus57Choice_ { }
}
