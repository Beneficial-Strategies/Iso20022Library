// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateType67Choice
{
    /// <summary>
    /// Rate expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mw355NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : RateType67Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the rate is fixed or variable or a forfeit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
