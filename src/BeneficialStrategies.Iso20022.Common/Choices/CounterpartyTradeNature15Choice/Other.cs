// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature15Choice
{
    /// <summary>
    /// Indicates that reporting party is other type of counterparty.
    /// </summary>
    [IsoId("_1z1A9wz1Ee2YoLD-1vFj0g")]
    [DisplayName("Other")]
    public partial record Other : CounterpartyTradeNature15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
