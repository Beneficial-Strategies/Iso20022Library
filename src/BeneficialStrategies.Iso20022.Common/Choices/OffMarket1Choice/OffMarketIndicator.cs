// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OffMarket1Choice
{
    /// <summary>
    /// Indicates that the trade was executed off-exchange.
    /// </summary>
    [IsoId("_TCpPodp-Ed-ak6NoX_4Aeg_2045804810")]
    [DisplayName("Off Market Indicator")]
    public record OffMarketIndicator : OffMarket1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the trade was executed off-market.
        /// </summary>
        [IsoXmlTag("OffMktInd")]
        public required OffMarket1Code Value { get; init; }
    }
}
