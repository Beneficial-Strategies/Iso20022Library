// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure4Choice
{
    /// <summary>
    /// Unit of measure expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_eoI2UeLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : UnitOfMeasure4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnitOfMeasure4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
