// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature5Choice
{
    /// <summary>
    /// Indicates that reporting party is other type of counterparty.
    /// </summary>
    [IsoId("_97ZDF7sAEea-m5tPqiasmQ")]
    [DisplayName("Other")]
    public partial record Other : CounterpartyTradeNature5Choice_
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
