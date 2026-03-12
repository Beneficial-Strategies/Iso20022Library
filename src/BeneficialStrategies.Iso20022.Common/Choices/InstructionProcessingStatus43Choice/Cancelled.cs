// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus43Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_pUH1rx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus43Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
