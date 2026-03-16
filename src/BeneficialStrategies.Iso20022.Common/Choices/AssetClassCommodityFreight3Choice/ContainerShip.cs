// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight3Choice
{
    /// <summary>
    /// Container ship freight commodity derivative.
    /// </summary>
    [IsoId("_VcEcVbv5EeiLRYqS-r-R-A")]
    [DisplayName("Container Ship")]
    public record ContainerShip : AssetClassCommodityFreight3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_i535x_wfEeW4Wthd0Ze_kA")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType4Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_i535xfwfEeW4Wthd0Ze_kA")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public required AssetClassSubProductType46Code SubProduct { get; init; }
    }
}
