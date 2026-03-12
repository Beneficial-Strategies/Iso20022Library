// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption1FormatChoice
{
    /// <summary>
    /// Option type expressed as a code.
    /// </summary>
    [IsoId("_RlgjQdp-Ed-ak6NoX_4Aeg_-1093032102")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionOption1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of CA options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOptionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
