// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Status13Choice.
    /// </summary>
    [KnownType(typeof(InstructionStatus13Choice.Pending))]
    [KnownType(typeof(InstructionStatus13Choice.ProcessingStatus))]
    [KnownType(typeof(InstructionStatus13Choice.Rejected))]
    [JsonDerivedType(
        typeof(InstructionStatus13Choice.Pending),
        nameof(InstructionStatus13Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus13Choice.ProcessingStatus),
        nameof(InstructionStatus13Choice.ProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionStatus13Choice.Rejected),
        nameof(InstructionStatus13Choice.Rejected)
    )]
    [IsoId("_Yq9FEYY_Ee-5eN4DwJpixA")]
    [DisplayName("Instruction Status13Choice")]
    public abstract record InstructionStatus13Choice_ { }
}
