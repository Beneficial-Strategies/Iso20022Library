// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus7Choice
{
    /// <summary>
    /// Provides status information related to an instruction request rejected for further processing due to system reasons.
    /// </summary>
    [IsoId("_U3YuB-JxEd-Q6MzBzY5WkA")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionProcessingStatus7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
