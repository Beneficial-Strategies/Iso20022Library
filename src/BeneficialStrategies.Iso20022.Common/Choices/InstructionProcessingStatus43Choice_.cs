// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus43Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Uncovered))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Accepted),
        nameof(InstructionProcessingStatus43Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Cancelled),
        nameof(InstructionProcessingStatus43Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Rejected),
        nameof(InstructionProcessingStatus43Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Pending),
        nameof(InstructionProcessingStatus43Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.PendingCancellation),
        nameof(InstructionProcessingStatus43Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Covered),
        nameof(InstructionProcessingStatus43Choice.Covered)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus43Choice.Uncovered),
        nameof(InstructionProcessingStatus43Choice.Uncovered)
    )]
    [IsoId("_pUH1qR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Processing Status 43 Choice")]
    public abstract record InstructionProcessingStatus43Choice_ { }
}
