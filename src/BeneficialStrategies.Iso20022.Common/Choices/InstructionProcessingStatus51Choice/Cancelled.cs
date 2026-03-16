// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus51Choice
{
    /// <summary>
    /// Cancelled.
    /// </summary>
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus51Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Canc")]
        public required CancelledStatus12Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
