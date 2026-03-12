// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCode1Choice
{
    /// <summary>
    /// Frequency expressed as a code.
    /// </summary>
    [IsoId("_Q7Vk5tp-Ed-ak6NoX_4Aeg_1533373116")]
    [DisplayName("Frequency As Code")]
    public partial record FrequencyAsCode : FrequencyCodeAndDSSCode1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("FrqcyAsCd")]
        public required EventFrequency1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
