// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus7Choice
{
    /// <summary>
    /// Reconciled.
    /// </summary>
    [DisplayName("Reconciled")]
    public partial record Reconciled : EventProcessingStatus7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rcncld")]
        public required NoSpecifiedReason1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
