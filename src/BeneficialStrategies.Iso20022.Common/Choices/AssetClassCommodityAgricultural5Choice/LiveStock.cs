// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural5Choice
{
    /// <summary>
    /// Livestock agricultural commodity derivative.
    /// </summary>
    [IsoId("_NxHXH7veEeiLRYqS-r-R-A")]
    [DisplayName("Live Stock")]
    [IsoXmlTag("LiveStock")]
    public record LiveStock : AssetClassCommodityAgricultural5Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_ftCeEFrAEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType1Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_oRBRUFrAEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType22Code SubProduct { get; init; }
    }
}
