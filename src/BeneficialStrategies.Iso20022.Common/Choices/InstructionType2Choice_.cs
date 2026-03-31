// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of instruction.
    /// </summary>
    [KnownType(typeof(InstructionType2Choice.InstructionIdentification))]
    [KnownType(typeof(InstructionType2Choice.InstructionCancellationIdentification))]
    [JsonDerivedType(
        typeof(InstructionType2Choice.InstructionIdentification),
        nameof(InstructionType2Choice.InstructionIdentification)
    )]
    [JsonDerivedType(
        typeof(InstructionType2Choice.InstructionCancellationIdentification),
        nameof(InstructionType2Choice.InstructionCancellationIdentification)
    )]
    [IsoId("_5chpEbmwEemdEs93hOkPKA")]
    [DisplayName("Instruction Type 2 Choice")]
    public abstract record InstructionType2Choice_ { }
}
