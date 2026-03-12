// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus36Choice
{
    /// <summary>
    /// Instruction cancelled by client cancellation instruction.
    /// </summary>
    [IsoId("_U39JFf0oEeiKOe8GCUL1Lg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus36Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
