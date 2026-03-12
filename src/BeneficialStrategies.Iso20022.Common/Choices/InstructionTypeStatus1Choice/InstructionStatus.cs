// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus1Choice
{
    /// <summary>
    /// Status applying to the instruction request received. The instruction is identified by the InstructionIdentification.
    /// </summary>
    [IsoId("_RCfVwNp-Ed-ak6NoX_4Aeg_-1678428958")]
    [DisplayName("Instruction Status")]
    public partial record InstructionStatus : InstructionTypeStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
