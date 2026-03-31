// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper1Choice
{
    /// <summary>
    /// Newsprint commodity derivative.
    /// </summary>
    [IsoId("_StoVoFryEeWN79Bl6BUd3g")]
    [DisplayName("Newsprint")]
    [IsoXmlTag("Nwsprnt")]
    public record Newsprint : AssetClassCommodityPaper1Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_Qx4aoFryEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType8Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_zT-VsFryEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType36Code? SubProduct { get; init; }
    }
}
