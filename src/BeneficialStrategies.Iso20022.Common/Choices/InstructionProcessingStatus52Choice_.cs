// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status52Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus52Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus52Choice.Uncovered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Accepted),nameof(InstructionProcessingStatus52Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus52Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Cancelled),nameof(InstructionProcessingStatus52Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Covered),nameof(InstructionProcessingStatus52Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Pending),nameof(InstructionProcessingStatus52Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.PendingCancellation),nameof(InstructionProcessingStatus52Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Rejected),nameof(InstructionProcessingStatus52Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus52Choice.Uncovered),nameof(InstructionProcessingStatus52Choice.Uncovered))]
    [IsoId("_PptyAWHfEe6yt_d72zQZeQ")]
    [DisplayName("Instruction Processing Status52Choice")]
    public abstract partial record InstructionProcessingStatus52Choice_
    {
    }
}
