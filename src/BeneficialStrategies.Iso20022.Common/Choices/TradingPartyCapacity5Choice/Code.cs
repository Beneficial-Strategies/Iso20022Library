// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity5Choice
{
    /// <summary>
    /// Specifies the role of the party in the transaction expressed as a code.
    /// </summary>
    [IsoId("_ALITkMGyEeivTd4NUfCi2g")]
    [DisplayName("Code")]
    public partial record Code : TradingPartyCapacity5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of a trading party in a transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradingCapacity7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
