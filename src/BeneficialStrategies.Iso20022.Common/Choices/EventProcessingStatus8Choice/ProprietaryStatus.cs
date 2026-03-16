// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus8Choice
{
    /// <summary>
    /// Proprietary Status.
    /// </summary>
    [DisplayName("Proprietary Status")]
    public partial record ProprietaryStatus : EventProcessingStatus8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrtrySts")]
        public required ProprietaryStatusAndReason7 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
