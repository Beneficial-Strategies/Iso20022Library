// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport33Choice
{
    /// <summary>
    /// Valuation Update.
    /// </summary>
    [DisplayName("Valuation Update")]
    public record ValuationUpdate : TradeReport33Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ValtnUpd")]
        public required TradeData43 Value { get; init; }
    }
}
