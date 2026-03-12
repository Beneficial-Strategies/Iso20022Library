// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice32Choice
{
    /// <summary>
    /// Type of price expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TJ-NZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : TypeOfPrice32Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice14Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
