// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CalculationType3Choice
{
    /// <summary>
    /// Calculation type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_M0gcoeLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : CalculationType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the yield computation method.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CalculationType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
