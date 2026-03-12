// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingReason3Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(InstructionProcessingReason3Choice.Reason),nameof(InstructionProcessingReason3Choice.Reason))]
    [JsonDerivedType(typeof(InstructionProcessingReason3Choice.NoSpecifiedReason),nameof(InstructionProcessingReason3Choice.NoSpecifiedReason))]
    [IsoId("_x4XDpwarEe2phaVG0lYKTw")]
    [DisplayName("Instruction Processing Reason 3 Choice")]
    public abstract partial record InstructionProcessingReason3Choice_
    {
    }
}
