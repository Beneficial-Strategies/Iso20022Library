// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityMetal2Choice
{
    /// <summary>
    /// Precious metal commodity derivative.
    /// </summary>
    [IsoId("_Dn_6o08REe2PGo0mhYCh1g")]
    [DisplayName("Precious")]
    [IsoXmlTag("Prcs")]
    public record Precious : AssetClassCommodityMetal2Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_LIOx4U8REe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType7Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_LIOx408REe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType16Code? SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_LIOx5U8REe2PGo0mhYCh1g")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public AssetClassDetailedSubProductType11Code? AdditionalSubProduct { get; init; }
    }
}
