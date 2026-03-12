// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus41Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_4Yit9e6KEeqc-LCjwLsUVg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus41Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
