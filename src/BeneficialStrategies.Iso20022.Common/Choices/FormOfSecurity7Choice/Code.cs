// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FormOfSecurity7Choice
{
    /// <summary>
    /// Form of the security expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5NZU0JNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : FormOfSecurity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Form of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FormOfSecurity1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
