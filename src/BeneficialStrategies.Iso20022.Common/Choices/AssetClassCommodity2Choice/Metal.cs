// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for metal type of commodities.
    /// </summary>
    [IsoId("_BzEmOyYyEeWHeosc_5RQEw")]
    [DisplayName("Metal")]
    public record Metal : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for metal related derivative contracts.
        /// </summary>
        [IsoXmlTag("Metl")]
        public required AssetClassSubProductMetal1Code Value { get; init; }
    }
}
