// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus53Choice
{
    /// <summary>
    /// Rejected.
    /// </summary>
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionProcessingStatus53Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus59Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
