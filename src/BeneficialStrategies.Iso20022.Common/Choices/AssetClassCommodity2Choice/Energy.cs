// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Code list for energy type of commodities.
    /// </summary>
    [IsoId("_BzEmOiYyEeWHeosc_5RQEw")]
    [DisplayName("Energy")]
    public record Energy : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code list for energy related derivative contracts.
        /// </summary>
        [IsoXmlTag("Nrgy")]
        public required AssetClassSubProductEnergyType1Code Value { get; init; }
    }
}
