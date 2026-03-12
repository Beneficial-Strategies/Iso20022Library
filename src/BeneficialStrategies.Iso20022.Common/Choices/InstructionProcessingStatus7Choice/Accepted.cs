// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus7Choice
{
    /// <summary>
    /// Provides status information related to an instruction request accepted for further processing.
    /// </summary>
    [IsoId("_U3YuBeJxEd-Q6MzBzY5WkA")]
    [DisplayName("Accepted")]
    public partial record Accepted : InstructionProcessingStatus7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
