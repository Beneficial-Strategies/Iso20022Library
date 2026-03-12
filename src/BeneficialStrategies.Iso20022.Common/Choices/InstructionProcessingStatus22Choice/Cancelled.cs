// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus22Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_hlFovTnuEeWfSKvvZlhRKg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus22Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
