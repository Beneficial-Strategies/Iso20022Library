// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPolypropylene3Choice
{
    /// <summary>
    /// Other commodity derivative
    /// </summary>
    [IsoId("_Pv61ALv9EeiLRYqS-r-R-A")]
    [DisplayName("Other")]
    public record Other : AssetClassCommodityPolypropylene3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_SM08Ubv9EeiLRYqS-r-R-A")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType9Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_SM08U7v9EeiLRYqS-r-R-A")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType49Code SubProduct { get; init; }
    }
}
