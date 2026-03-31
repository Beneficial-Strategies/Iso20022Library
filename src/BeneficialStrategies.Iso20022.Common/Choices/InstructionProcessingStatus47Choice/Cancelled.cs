// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus47Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_KVKx1Rn1EeyroI8qKgB7Mg")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus47Choice_ { }
}
