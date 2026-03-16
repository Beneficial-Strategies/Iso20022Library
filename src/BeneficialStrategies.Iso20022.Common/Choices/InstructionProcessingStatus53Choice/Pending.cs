// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus53Choice
{
    /// <summary>
    /// Pending.
    /// </summary>
    [DisplayName("Pending")]
    public partial record Pending : InstructionProcessingStatus53Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pdg")]
        public required PendingStatus72Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
