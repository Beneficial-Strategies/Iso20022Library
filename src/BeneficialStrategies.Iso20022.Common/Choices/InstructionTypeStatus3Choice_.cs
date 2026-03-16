// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of instruction type status.
    /// </summary>
    [KnownType(typeof(InstructionTypeStatus3Choice.InstructionStatus))]
    [KnownType(typeof(InstructionTypeStatus3Choice.CancellationStatus))]
    [JsonDerivedType(
        typeof(InstructionTypeStatus3Choice.InstructionStatus),
        nameof(InstructionTypeStatus3Choice.InstructionStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionTypeStatus3Choice.CancellationStatus),
        nameof(InstructionTypeStatus3Choice.CancellationStatus)
    )]
    [IsoId("_7xaDIa-nEemJ1NnLPsTFaw")]
    [DisplayName("Instruction Type Status 3 Choice")]
    public abstract record InstructionTypeStatus3Choice_ { }
}
