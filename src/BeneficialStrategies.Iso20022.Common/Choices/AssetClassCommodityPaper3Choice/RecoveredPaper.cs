// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper3Choice
{
    /// <summary>
    /// Recovered paper commodity derivative.
    /// </summary>
    [IsoId("__n-Wh7v7EeiLRYqS-r-R-A")]
    [DisplayName("Recovered Paper")]
    [IsoXmlTag("RcvrdPpr")]
    public record RecoveredPaper : AssetClassCommodityPaper3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_f__jkFryEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType8Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_Bey1oFrzEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType38Code? SubProduct { get; init; }
    }
}
