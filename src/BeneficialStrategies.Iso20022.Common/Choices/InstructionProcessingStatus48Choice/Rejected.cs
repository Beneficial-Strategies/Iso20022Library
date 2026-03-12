// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus48Choice
{
    /// <summary>
    /// Instruction rejected by the receiver.
    /// </summary>
    [IsoId("_pf9iUzi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionProcessingStatus48Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
