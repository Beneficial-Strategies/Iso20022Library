// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus48Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_pf9iQzi7Eeydid5dcNPKvg")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus48Choice_ { }
}
