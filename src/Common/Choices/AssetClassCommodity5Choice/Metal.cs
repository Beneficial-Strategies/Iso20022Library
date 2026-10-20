// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Metal commodities.
    /// </summary>
    [IsoId("_owQIPbtIEeiLRYqS-r-R-A")]
    [DisplayName("Metal")]
    public partial record Metal : AssetClassCommodity5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Metl")]
        public required AssetClassCommodityMetal1Choice_ Value { get; init; }
    }
}
