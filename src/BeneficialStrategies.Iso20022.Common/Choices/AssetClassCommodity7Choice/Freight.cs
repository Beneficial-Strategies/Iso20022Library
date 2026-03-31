// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity7Choice
{
    /// <summary>
    /// Freight.
    /// </summary>
    [DisplayName("Freight")]
    public record Freight : AssetClassCommodity7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Frght")]
        public required AssetClassCommodityFreight4Choice_ Value { get; init; }
    }
}
