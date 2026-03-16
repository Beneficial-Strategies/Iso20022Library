// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for environmental type of commodities.
    /// </summary>
    [IsoId("_BzEmPiYyEeWHeosc_5RQEw")]
    [DisplayName("Environmental")]
    public record Environmental : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for environmental related derivative contracts.
        /// </summary>
        [IsoXmlTag("Envttl")]
        public required AssetClassSubProductEnvironmentalType1Code Value { get; init; }
    }
}
