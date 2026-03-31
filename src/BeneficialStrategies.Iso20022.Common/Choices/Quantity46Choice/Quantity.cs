// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity46Choice
{
    /// <summary>
    /// Quantity of delivery.
    /// </summary>
    [IsoId("_28-GQZCuEeic-NeLxeO3hQ")]
    [DisplayName("Quantity")]
    public record Quantity : Quantity46Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
        public required IsoLongFraction21DecimalNumber Value { get; init; }
    }
}
