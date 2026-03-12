// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_7X_7JQpJEeup4r-PFG2T5Q")]
    [DisplayName("Repair")]
    public partial record Repair : InstructionProcessingStatus42Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
