// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Official Economic Statistics commodities.
    /// </summary>
    [IsoId("_owQISbtIEeiLRYqS-r-R-A")]
    [DisplayName("Official Economic Statistics")]
    public record OfficialEconomicStatistics : AssetClassCommodity5Choice_
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
