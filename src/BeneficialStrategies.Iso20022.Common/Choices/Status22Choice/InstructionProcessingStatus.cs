// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status22Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_8QboL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status")]
    public partial record InstructionProcessingStatus : Status22Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
