// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural1Choice
{
    /// <summary>
    /// Olive oil agricultural commodity derivative.
    /// </summary>
    [IsoId("_VQFYYw2jEeW72qLtWESimw")]
    [DisplayName("Olive Oil")]
    [IsoXmlTag("OlvOil")]
    public record OliveOil : AssetClassCommodityAgricultural1Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_NtOq5g2jEeW72qLtWESimw")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType1Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_NtOq5Q2jEeW72qLtWESimw")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType3Code SubProduct { get; init; }

        /// <summary>
        /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
        /// </summary>
        [IsoId("_NtOq5w2jEeW72qLtWESimw")]
        [DisplayName("Additional Sub Product")]
        [IsoXmlTag("AddtlSubPdct")]
        public AssetClassDetailedSubProductType4Code? AdditionalSubProduct { get; init; }
    }
}
