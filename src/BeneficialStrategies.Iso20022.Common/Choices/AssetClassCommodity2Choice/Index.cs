// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice
{
    /// <summary>
    /// Indicates the index type of commodities.
    /// </summary>
    [IsoId("_BzEmPCYyEeWHeosc_5RQEw")]
    [DisplayName("Index")]
    public record Index : AssetClassCommodity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Indx")]
        public required NoReasonCode Value { get; init; }
    }
}
