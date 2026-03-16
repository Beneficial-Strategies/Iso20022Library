// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus2Choice
{
    /// <summary>
    /// Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_rZOb0V6uEeSyc4g_pm5hbw")]
    [DisplayName("Instruction Status")]
    public record InstructionStatus : InstructionTypeStatus2Choice_ { }
}
