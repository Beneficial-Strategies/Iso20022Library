// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPolypropylene4Choice
{
    /// <summary>
    /// Other commodity derivative
    /// </summary>
    [IsoId("_ySLgwxZZEe2QNcZTDeoKnQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : AssetClassCommodityPolypropylene4Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_6nSvIU8QEe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType9Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_6nSvI08QEe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType49Code? SubProduct { get; init; }
    }
}
