// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding3Choice
{
    /// <summary>
    /// Commodity.
    /// </summary>
    [DisplayName("Commodity")]
    public record Commodity : AssetHolding3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmmdty")]
        public required Commodity2 Value { get; init; }
    }
}
