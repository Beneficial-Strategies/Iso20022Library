// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer3Choice
{
    /// <summary>
    /// Urea and ammonium nitrate fertilizer commodity derivative.
    /// </summary>
    [IsoId("_K_pO27v7EeiLRYqS-r-R-A")]
    [DisplayName("Urea And Ammonium Nitrate")]
    [IsoXmlTag("UreaAndAmmnmNtrt")]
    public record UreaAndAmmoniumNitrate : AssetClassCommodityFertilizer3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_CDm2EFr3EeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType5Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_0AGpoFr3EeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType44Code SubProduct { get; init; }
    }
}
