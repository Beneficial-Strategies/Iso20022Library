// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status6Choice
{
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_Su5UCQEcEeCQm6a_G2yO_w_-1725538061")]
    [DisplayName("Code")]
    public partial record Code : Status6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a trade in a central matching and settlement system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeStatus4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
