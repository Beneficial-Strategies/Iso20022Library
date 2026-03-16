// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityMetal1Choice
{
    /// <summary>
    /// Precious metal commodity derivative.
    /// </summary>
    [IsoId("_D1rdVQ2rEeW72qLtWESimw")]
    [DisplayName("Precious")]
    [IsoXmlTag("Prcs")]
    public record Precious : AssetClassCommodityMetal1Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_ZEBqZQ2rEeW72qLtWESimw")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType7Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_ZEBqZw2rEeW72qLtWESimw")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType16Code SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_ZEBqZg2rEeW72qLtWESimw")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public required AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; }
    }
}
