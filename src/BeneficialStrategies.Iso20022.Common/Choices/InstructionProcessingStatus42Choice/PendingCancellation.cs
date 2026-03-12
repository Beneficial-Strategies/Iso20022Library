// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice
{
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// </summary>
    [IsoId("_7X_7KQpJEeup4r-PFG2T5Q")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : InstructionProcessingStatus42Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
