// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure7Choice
{
    /// <summary>
    /// Unit of measure expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_rnXegWp8EemmaZLSPtWX5A")]
    [DisplayName("Code")]
    public partial record Code : UnitOfMeasure7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnitOfMeasure9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
