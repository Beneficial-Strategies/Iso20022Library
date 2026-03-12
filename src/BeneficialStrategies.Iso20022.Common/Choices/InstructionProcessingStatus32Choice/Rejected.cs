// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus32Choice
{
    /// <summary>
    /// Instruction rejected by the receiver.
    /// </summary>
    [IsoId("_BfFOBLtTEeilsanBGAzy4A")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionProcessingStatus32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
