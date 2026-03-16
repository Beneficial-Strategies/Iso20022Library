// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity32Choice
{
    /// <summary>
    /// Quantity expressed as a number, such as a number of shares.
    /// </summary>
    [IsoId("_Y7YBcZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantity32Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, such as 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
        public required IsoLongFraction19DecimalNumber Value { get; init; }
    }
}
