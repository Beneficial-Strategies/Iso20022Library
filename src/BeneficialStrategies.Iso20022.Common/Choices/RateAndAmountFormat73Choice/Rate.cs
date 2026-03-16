// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat73Choice
{
    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    public partial record Rate : RateAndAmountFormat73Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rate")]
        public required IsoPercentage14Rate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
