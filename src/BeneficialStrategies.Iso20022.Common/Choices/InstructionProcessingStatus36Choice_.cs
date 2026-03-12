// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus36Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus36Choice.Uncovered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Accepted),nameof(InstructionProcessingStatus36Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Cancelled),nameof(InstructionProcessingStatus36Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus36Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Rejected),nameof(InstructionProcessingStatus36Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Pending),nameof(InstructionProcessingStatus36Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.PendingCancellation),nameof(InstructionProcessingStatus36Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Covered),nameof(InstructionProcessingStatus36Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus36Choice.Uncovered),nameof(InstructionProcessingStatus36Choice.Uncovered))]
    [IsoId("_UUGOEf0oEeiKOe8GCUL1Lg")]
    [DisplayName("Instruction Processing Status 36 Choice")]
    public abstract partial record InstructionProcessingStatus36Choice_
    {
    }
}
