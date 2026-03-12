// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption11Choice
{
    /// <summary>
    /// Option type expressed as a code.
    /// </summary>
    [IsoId("_ony6ZQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionOption11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
