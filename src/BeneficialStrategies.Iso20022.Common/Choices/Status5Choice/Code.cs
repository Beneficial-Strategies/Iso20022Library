// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status5Choice
{
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_Su5UDAEcEeCQm6a_G2yO_w_1647711877")]
    [DisplayName("Code")]
    public partial record Code : Status5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a trade in a central matching and settlement system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeStatus3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
