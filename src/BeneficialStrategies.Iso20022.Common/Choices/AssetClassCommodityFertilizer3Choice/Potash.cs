// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer3Choice
{
    /// <summary>
    /// Potash fertilizer commodity derivative.
    /// </summary>
    [IsoId("_K_pO1bv7EeiLRYqS-r-R-A")]
    [DisplayName("Potash")]
    [IsoXmlTag("Ptsh")]
    public record Potash : AssetClassCommodityFertilizer3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_6r_vUFr2EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType5Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_ff5U8Fr3EeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType41Code SubProduct { get; init; }
    }
}
