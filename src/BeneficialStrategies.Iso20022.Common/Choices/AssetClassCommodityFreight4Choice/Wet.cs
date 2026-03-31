// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight4Choice
{
    /// <summary>
    /// Wet freight commodity derivative.
    /// </summary>
    [IsoId("_Rn91c08REe2PGo0mhYCh1g")]
    [DisplayName("Wet")]
    [IsoXmlTag("Wet")]
    public record Wet : AssetClassCommodityFreight4Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_XyUe4U8REe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType4Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_XyUe408REe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType32Code? SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_XyUe5U8REe2PGo0mhYCh1g")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public AssetClassDetailedSubProductType34Code? AdditionalSubProduct { get; init; }
    }
}
