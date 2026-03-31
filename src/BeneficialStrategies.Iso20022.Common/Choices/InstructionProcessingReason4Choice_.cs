// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingReason4Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason4Choice.NoSpecifiedReason))]
    [JsonDerivedType(
        typeof(InstructionProcessingReason4Choice.Reason),
        nameof(InstructionProcessingReason4Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingReason4Choice.NoSpecifiedReason),
        nameof(InstructionProcessingReason4Choice.NoSpecifiedReason)
    )]
    [IsoId("_gajPIQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Instruction Processing Reason 4 Choice")]
    public abstract record InstructionProcessingReason4Choice_ { }
}
