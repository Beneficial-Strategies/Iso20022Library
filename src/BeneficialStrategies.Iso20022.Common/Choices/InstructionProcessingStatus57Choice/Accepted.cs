// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus57Choice
{
    /// <summary>
    /// Accepted.
    /// </summary>
    [DisplayName("Accepted")]
    public partial record Accepted : InstructionProcessingStatus57Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Accptd")]
        public required NoSpecifiedReason1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
