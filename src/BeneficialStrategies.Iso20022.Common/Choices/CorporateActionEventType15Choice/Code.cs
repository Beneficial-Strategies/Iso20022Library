// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType15Choice
{
    /// <summary>
    /// Corporate action event type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_6xlPtRG6EeKHC-9MYSJwtQ")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType14Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
