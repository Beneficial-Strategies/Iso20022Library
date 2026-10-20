// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Agricultural commodities.
    /// </summary>
    [IsoId("_lThdYXvyEeanCNPcMT7sSg")]
    [DisplayName("Agricultural")]
    public partial record Agricultural : AssetClassCommodity3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Agrcltrl")]
        public required AssetClassCommodityAgricultural1Choice_ Value { get; init; }
    }
}
