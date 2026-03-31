// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight1Choice
{
    /// <summary>
    /// Wet freight commodity derivative.
    /// </summary>
    [IsoId("_9FcRwFrcEeWN79Bl6BUd3g")]
    [DisplayName("Wet")]
    [IsoXmlTag("Wet")]
    public record Wet : AssetClassCommodityFreight1Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_4K64gFrcEeWN79Bl6BUd3g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType4Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_gTfT4FrdEeWN79Bl6BUd3g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType32Code SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_xu1wcFrdEeWN79Bl6BUd3g")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public AssetClassDetailedSubProductType12Code? AdditionalSubProduct { get; init; }
    }
}
