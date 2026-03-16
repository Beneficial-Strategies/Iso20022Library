// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat56Choice
{
    /// <summary>
    /// Rate Type And Rate.
    /// </summary>
    [DisplayName("Rate Type And Rate")]
    public partial record RateTypeAndRate : RateAndAmountFormat56Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RateTpAndRate")]
        public required RateTypeAndPercentageRate12 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
