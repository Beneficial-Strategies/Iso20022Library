// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus1Choice
{
    /// <summary>
    /// Status applying globally to the instruction received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_RWnLqNp-Ed-ak6NoX_4Aeg_1691740935")]
    [DisplayName("Global Instruction Status")]
    public record GlobalInstructionStatus : InstructionStatus1Choice_ { }
}
