// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural5Choice
{
    /// <summary>
    /// Potato agricultural commodity derivative.
    /// </summary>
    [IsoId("_NxHXFbveEeiLRYqS-r-R-A")]
    [DisplayName("Potato")]
    [IsoXmlTag("Ptt")]
    public record Potato : AssetClassCommodityAgricultural5Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_yaQl1PwcEeW4Wthd0Ze_kA")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType1Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_yaQl1fwcEeW4Wthd0Ze_kA")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType45Code SubProduct { get; init; }
    }
}
