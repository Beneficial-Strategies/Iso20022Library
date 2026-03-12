// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateValueType2FormatChoice
{
    /// <summary>
    /// Standard code to specify the value of a rate.
    /// </summary>
    [IsoId("_Rn5I5dp-Ed-ak6NoX_4Aeg_-895977923")]
    [DisplayName("Code")]
    public partial record Code : RateValueType2FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateValueType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
