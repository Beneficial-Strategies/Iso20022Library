// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingReason1Choice.Reason))]
    [KnownType(typeof(InstructionProcessingReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(InstructionProcessingReason1Choice.Reason),nameof(InstructionProcessingReason1Choice.Reason))]
    [JsonDerivedType(typeof(InstructionProcessingReason1Choice.NoSpecifiedReason),nameof(InstructionProcessingReason1Choice.NoSpecifiedReason))]
    [IsoId("_Azyp49okEeC60axPepSq7g_-773750122")]
    [DisplayName("Instruction Processing Reason 1 Choice")]
    public abstract partial record InstructionProcessingReason1Choice_
    {
    }
}
