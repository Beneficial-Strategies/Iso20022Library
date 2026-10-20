// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Metal commodities.
    /// </summary>
    [IsoId("_1bgUHRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Metal")]
    public partial record Metal : AssetClassCommodity6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Metl")]
        public required AssetClassCommodityMetal2Choice_ Value { get; init; }
    }
}
