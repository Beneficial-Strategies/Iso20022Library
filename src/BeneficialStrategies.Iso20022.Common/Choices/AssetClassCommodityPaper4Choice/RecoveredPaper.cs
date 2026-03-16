// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper4Choice
{
    /// <summary>
    /// Recovered paper commodity derivative.
    /// </summary>
    [IsoId("_FsdvNxZaEe2QNcZTDeoKnQ")]
    [DisplayName("Recovered Paper")]
    [IsoXmlTag("RcvrdPpr")]
    public record RecoveredPaper : AssetClassCommodityPaper4Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_WmUoQRZaEe2QNcZTDeoKnQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType8Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_WmUoQxZaEe2QNcZTDeoKnQ")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType49Code? SubProduct { get; init; }
    }
}
