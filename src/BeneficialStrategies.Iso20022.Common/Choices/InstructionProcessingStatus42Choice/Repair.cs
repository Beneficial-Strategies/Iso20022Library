// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_7X_7JQpJEeup4r-PFG2T5Q")]
    [DisplayName("Repair")]
    public record Repair : InstructionProcessingStatus42Choice_ { }
}
