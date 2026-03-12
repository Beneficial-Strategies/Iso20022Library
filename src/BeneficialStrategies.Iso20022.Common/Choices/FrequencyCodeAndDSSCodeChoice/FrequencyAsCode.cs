// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCodeChoice
{
    /// <summary>
    /// Frequency expressed as a code.
    /// </summary>
    [IsoId("_Uuhiodp-Ed-ak6NoX_4Aeg_501343039")]
    [DisplayName("Frequency As Code")]
    public partial record FrequencyAsCode : FrequencyCodeAndDSSCodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("FrqcyAsCd")]
        public required Frequency1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
