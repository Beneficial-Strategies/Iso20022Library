// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType1CodeChoice
{
    /// <summary>
    /// Corporate action event type in a structured format.
    /// </summary>
    [IsoId("_UyZ9Gdp-Ed-ak6NoX_4Aeg_983611068")]
    [DisplayName("Structured")]
    public partial record Structured : CorporateActionEventType1CodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action event.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required CorporateActionEventType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
