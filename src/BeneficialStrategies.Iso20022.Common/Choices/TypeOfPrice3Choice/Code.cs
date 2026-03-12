// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice3Choice
{
    /// <summary>
    /// Type of price expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qu0y4tp-Ed-ak6NoX_4Aeg_-583980602")]
    [DisplayName("Code")]
    public partial record Code : TypeOfPrice3Choice_
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
