// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer3Choice
{
    /// <summary>
    /// Other fertilizer commodity derivative.
    /// </summary>
    [IsoId("_QbBSYLv7EeiLRYqS-r-R-A")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : AssetClassCommodityFertilizer3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_VI6k4bv7EeiLRYqS-r-R-A")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType5Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_VI6k47v7EeiLRYqS-r-R-A")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType49Code SubProduct { get; init; }
    }
}
