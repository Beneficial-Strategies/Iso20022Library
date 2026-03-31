// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus26Choice.Code))]
    [KnownType(typeof(InstructionProcessingStatus26Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus26Choice.Code),
        nameof(InstructionProcessingStatus26Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus26Choice.Proprietary),
        nameof(InstructionProcessingStatus26Choice.Proprietary)
    )]
    [IsoId("_8QcO2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status 26 Choice")]
    public abstract record InstructionProcessingStatus26Choice_ { }
}
