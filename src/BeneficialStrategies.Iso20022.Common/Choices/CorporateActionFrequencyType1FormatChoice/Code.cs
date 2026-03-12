// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionFrequencyType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the frequency of a CA event.
    /// </summary>
    [IsoId("_RmZ7INp-Ed-ak6NoX_4Aeg_1510389883")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionFrequencyType1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the frequency of a CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
