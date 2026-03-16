// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity5Choice
{
    /// <summary>
    /// Specifies the role of the party in the transaction expressed as a code.
    /// </summary>
    [IsoId("_ALITkMGyEeivTd4NUfCi2g")]
    [DisplayName("Code")]
    public record Code : TradingPartyCapacity5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of a trading party in a transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradingCapacity7Code Value { get; init; }
    }
}
