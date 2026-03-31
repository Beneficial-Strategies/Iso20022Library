// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus33Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_Jo5gtdB7EeihG9bKfarOOA")]
    [DisplayName("Repair")]
    public record Repair : InstructionProcessingStatus33Choice_ { }
}
