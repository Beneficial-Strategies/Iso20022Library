// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status56Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus56Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Returned))]
    [KnownType(typeof(InstructionProcessingStatus56Choice.Uncovered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Accepted),nameof(InstructionProcessingStatus56Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus56Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Cancelled),nameof(InstructionProcessingStatus56Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Covered),nameof(InstructionProcessingStatus56Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Pending),nameof(InstructionProcessingStatus56Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.PendingCancellation),nameof(InstructionProcessingStatus56Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Rejected),nameof(InstructionProcessingStatus56Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Returned),nameof(InstructionProcessingStatus56Choice.Returned))]
    [JsonDerivedType(typeof(InstructionProcessingStatus56Choice.Uncovered),nameof(InstructionProcessingStatus56Choice.Uncovered))]
    [IsoId("_kvF0CYVQEe-oeNhl-Tk6YQ")]
    [DisplayName("Instruction Processing Status56Choice")]
    public abstract partial record InstructionProcessingStatus56Choice_
    {
    }
}
