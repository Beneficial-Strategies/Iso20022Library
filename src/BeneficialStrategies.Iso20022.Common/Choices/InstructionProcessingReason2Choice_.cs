// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingReason2Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(InstructionProcessingReason2Choice.Reason),nameof(InstructionProcessingReason2Choice.Reason))]
    [JsonDerivedType(typeof(InstructionProcessingReason2Choice.NoSpecifiedReason),nameof(InstructionProcessingReason2Choice.NoSpecifiedReason))]
    [IsoId("_Azo449okEeC60axPepSq7g_-1958453728")]
    [DisplayName("Instruction Processing Reason 2 Choice")]
    public abstract partial record InstructionProcessingReason2Choice_
    {
    }
}
