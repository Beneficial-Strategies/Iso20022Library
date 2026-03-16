// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Indicates the exotic type of commodities.
    /// </summary>
    [IsoId("_BzEmPSYyEeWHeosc_5RQEw")]
    [DisplayName("Exotic")]
    public record Exotic : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Extc")]
        public required NoReasonCode Value { get; init; }
    }
}
