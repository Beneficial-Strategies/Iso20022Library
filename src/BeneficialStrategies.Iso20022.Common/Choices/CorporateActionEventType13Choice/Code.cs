// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType13Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_1Ri0QBEuEeKp2ZN13DI_pA")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
