// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConsentTypeFormat5Choice
{
    /// <summary>
    /// Standard code to specify the consent type required.
    /// </summary>
    [IsoId("_c5WhgZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : ConsentTypeFormat5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of consent announced.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConsentType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
