// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus8Choice
{
    /// <summary>
    /// Complete.
    /// </summary>
    [DisplayName("Complete")]
    public partial record Complete : EventProcessingStatus8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmplt")]
        public required NoSpecifiedReason1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
