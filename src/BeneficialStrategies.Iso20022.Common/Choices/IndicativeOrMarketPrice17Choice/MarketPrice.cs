// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice17Choice
{
    /// <summary>
    /// Market Price.
    /// </summary>
    [DisplayName("Market Price")]
    public record MarketPrice : IndicativeOrMarketPrice17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MktPric")]
        public required PriceFormat88Choice_ Value { get; init; }
    }
}
