// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingType2Choice
{
    /// <summary>
    /// Standard code to specify the processing type of a corporate action event.
    /// </summary>
    [IsoId("_RYH6kTndEeWLJsP1cO-amg")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventProcessingType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of event processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventProcessingType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
