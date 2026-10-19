// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Energy commodities.
    /// </summary>
    [IsoId("_owQIM7tIEeiLRYqS-r-R-A")]
    [DisplayName("Energy")]
    public partial record Energy : AssetClassCommodity5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Nrgy")]
        public required AssetClassCommodityEnergy2Choice_ Value { get; init; }
    }
}
