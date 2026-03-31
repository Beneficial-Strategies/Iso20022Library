// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Official Economic Statistics commodities.
    /// </summary>
    [IsoId("_1bgUKRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Official Economic Statistics")]
    public record OfficialEconomicStatistics : AssetClassCommodity6Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_-mgvAFr0EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType14Code BaseProduct { get; init; }
    }
}
