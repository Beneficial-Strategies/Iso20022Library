// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus5Choice
{
    /// <summary>
    /// Status applying globally to the instruction received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_r15ww16uEeSyc4g_pm5hbw")]
    [DisplayName("Global Instruction Status")]
    public record GlobalInstructionStatus : InstructionStatus5Choice_ { }
}
