// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus23Choice.Code))]
    [KnownType(typeof(InstructionProcessingStatus23Choice.Proprietary))]
    [JsonDerivedType(typeof(InstructionProcessingStatus23Choice.Code),nameof(InstructionProcessingStatus23Choice.Code))]
    [JsonDerivedType(typeof(InstructionProcessingStatus23Choice.Proprietary),nameof(InstructionProcessingStatus23Choice.Proprietary))]
    [IsoId("_bjXQYTqqEeWyoP0PbocV1Q")]
    [DisplayName("Instruction Processing Status 23 Choice")]
    public abstract partial record InstructionProcessingStatus23Choice_
    {
    }
}
