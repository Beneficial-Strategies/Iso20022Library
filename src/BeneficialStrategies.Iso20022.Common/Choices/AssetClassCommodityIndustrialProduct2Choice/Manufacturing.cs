// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityIndustrialProduct2Choice
{
    /// <summary>
    /// Manufacturing related industrial product commodity derivative.
    /// </summary>
    [IsoId("_OTrSExZZEe2QNcZTDeoKnQ")]
    [DisplayName("Manufacturing")]
    public record Manufacturing : AssetClassCommodityIndustrialProduct2Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_VcqG8RZZEe2QNcZTDeoKnQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType6Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_VcqG8xZZEe2QNcZTDeoKnQ")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType34Code? SubProduct { get; init; }
    }
}
