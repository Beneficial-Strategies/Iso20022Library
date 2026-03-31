// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding3Choice
{
    /// <summary>
    /// Guarantee.
    /// </summary>
    [DisplayName("Guarantee")]
    public record Guarantee : AssetHolding3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Grnt")]
        public required Guarantee1 Value { get; init; }
    }
}
