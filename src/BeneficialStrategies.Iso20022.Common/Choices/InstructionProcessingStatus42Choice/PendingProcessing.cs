// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("_7X_7EQpJEeup4r-PFG2T5Q")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : InstructionProcessingStatus42Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
