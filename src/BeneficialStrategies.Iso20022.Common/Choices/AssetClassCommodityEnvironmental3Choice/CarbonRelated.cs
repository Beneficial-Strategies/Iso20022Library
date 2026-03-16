// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental3Choice
{
    /// <summary>
    /// Carbon related environmental commodity derivative.
    /// </summary>
    [IsoId("_9cj2pU8REe2PGo0mhYCh1g")]
    [DisplayName("Carbon Related")]
    [IsoXmlTag("CrbnRltd")]
    public record CarbonRelated : AssetClassCommodityEnvironmental3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_F1mlMU8SEe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType3Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_F1mlM08SEe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType29Code? SubProduct { get; init; }
    }
}
