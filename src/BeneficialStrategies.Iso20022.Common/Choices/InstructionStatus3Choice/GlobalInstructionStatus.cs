// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus3Choice
{
    /// <summary>
    /// Status applying globally to the instruction received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_RCpGw9p-Ed-ak6NoX_4Aeg_1721093163")]
    [DisplayName("Global Instruction Status")]
    public partial record GlobalInstructionStatus : InstructionStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
