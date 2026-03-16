// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy3Choice
{
    /// <summary>
    /// Other energy commodity derivative.
    /// </summary>
    [IsoId("_O67yEU8SEe2PGo0mhYCh1g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : AssetClassCommodityEnergy3Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_sIQAwU8SEe2PGo0mhYCh1g")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType2Code BaseProduct { get; init; }

        /// <summary>
        /// Sub-product for the underlying asset class.
        /// </summary>
        [IsoId("_sIQAw08SEe2PGo0mhYCh1g")]
        [DisplayName("Sub Product")]
        [IsoXmlTag("SubPdct")]
        public AssetClassSubProductType49Code? SubProduct { get; init; }
    }
}
