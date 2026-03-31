// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer3Choice
{
    /// <summary>
    /// Sulphur fertilizer commodity derivative.
    /// </summary>
    [IsoId("_K_pO17v7EeiLRYqS-r-R-A")]
    [DisplayName("Sulphur")]
    [IsoXmlTag("Slphr")]
    public record Sulphur : AssetClassCommodityFertilizer3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_86rNYFr2EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType5Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_nmWesFr3EeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType42Code SubProduct { get; init; }
    }
}
