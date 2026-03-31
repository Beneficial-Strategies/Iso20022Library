// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy2Choice
{
    /// <summary>
    /// Light end energy commodity derivative.
    /// </summary>
    [IsoId("_x4yAfbvsEeiLRYqS-r-R-A")]
    [DisplayName("Light End")]
    [IsoXmlTag("LghtEnd")]
    public record LightEnd : AssetClassCommodityEnergy2Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_BUt9UFrXEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType2Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_FSmIIFrXEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType27Code SubProduct { get; init; }
    }
}
