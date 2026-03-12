// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionType4Choice
{
    /// <summary>
    /// Option type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AbgFs9okEeC60axPepSq7g_820437301")]
    [DisplayName("Code")]
    public partial record Code : OptionType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
