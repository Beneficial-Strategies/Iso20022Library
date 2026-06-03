// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different processing statuses for a corporate action instruction.</summary>
    [KnownType(typeof(InstructionProcessingStatus62Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Accepted), nameof(InstructionProcessingStatus62Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Cancelled), nameof(InstructionProcessingStatus62Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.AcceptedForFurtherProcessing), nameof(InstructionProcessingStatus62Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Rejected), nameof(InstructionProcessingStatus62Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Pending), nameof(InstructionProcessingStatus62Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.PendingCancellation), nameof(InstructionProcessingStatus62Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Covered), nameof(InstructionProcessingStatus62Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Uncovered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Uncovered), nameof(InstructionProcessingStatus62Choice.Uncovered))]
    [KnownType(typeof(InstructionProcessingStatus62Choice.Returned))]
    [JsonDerivedType(typeof(InstructionProcessingStatus62Choice.Returned), nameof(InstructionProcessingStatus62Choice.Returned))]
    [IsoId("_H2cl8a8wEfCx2aBifPEdRg")]
    [DisplayName("Instruction Processing Status 62 Choice")]
    public abstract record InstructionProcessingStatus62Choice_ { }
}
