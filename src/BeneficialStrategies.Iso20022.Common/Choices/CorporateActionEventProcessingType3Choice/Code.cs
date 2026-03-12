// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingType3Choice
{
    /// <summary>
    /// Standard code to specify the processing type of a corporate action event.
    /// </summary>
    [IsoId("_ctOws5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventProcessingType3Choice_
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
