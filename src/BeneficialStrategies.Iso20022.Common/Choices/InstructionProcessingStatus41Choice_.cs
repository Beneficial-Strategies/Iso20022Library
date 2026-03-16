// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus41Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Uncovered))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Accepted),
        nameof(InstructionProcessingStatus41Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Cancelled),
        nameof(InstructionProcessingStatus41Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Rejected),
        nameof(InstructionProcessingStatus41Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Pending),
        nameof(InstructionProcessingStatus41Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.PendingCancellation),
        nameof(InstructionProcessingStatus41Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Covered),
        nameof(InstructionProcessingStatus41Choice.Covered)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus41Choice.Uncovered),
        nameof(InstructionProcessingStatus41Choice.Uncovered)
    )]
    [IsoId("_4FWsSe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Processing Status 41 Choice")]
    public abstract record InstructionProcessingStatus41Choice_ { }
}
