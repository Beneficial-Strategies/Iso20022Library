// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice13Choice
{
    /// <summary>
    /// Indicative Price.
    /// </summary>
    [DisplayName("Indicative Price")]
    public record IndicativePrice : IndicativeOrMarketPrice13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndctvPric")]
        public required PriceFormat77Choice_ Value { get; init; }
    }
}
