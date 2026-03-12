// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarginType2Choice
{
    /// <summary>
    /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
    /// </summary>
    [IsoId("_7-1ooI1rEeet3cKIYK84nw")]
    [DisplayName("Code")]
    public partial record Code : MarginType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
