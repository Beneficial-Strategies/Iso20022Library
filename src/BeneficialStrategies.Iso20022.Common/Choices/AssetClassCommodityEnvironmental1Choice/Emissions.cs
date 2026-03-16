// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental1Choice
{
    /// <summary>
    /// Emissions environmental commodity derivative.
    /// </summary>
    [IsoId("_aQGG1w2pEeW72qLtWESimw")]
    [DisplayName("Emissions")]
    [IsoXmlTag("Emssns")]
    public record Emissions : AssetClassCommodityEnvironmental1Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_6msQJQ2oEeW72qLtWESimw")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType3Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_6msQJA2oEeW72qLtWESimw")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType10Code SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_FW6RcQ2pEeW72qLtWESimw")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public AssetClassDetailedSubProductType8Code? AdditionalSubProduct { get; init; }
    }
}
