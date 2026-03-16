// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetHolding3Choice
{
    /// <summary>
    /// Gold.
    /// </summary>
    [DisplayName("Gold")]
    public record Gold : AssetHolding3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Gold")]
        public required ActiveCurrencyAndAmount Value { get; init; }
    }
}
