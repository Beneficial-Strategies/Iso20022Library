// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity30Choice
{
    /// <summary>
    /// Quantity expressed as a number, such as a number of shares.
    /// </summary>
    [IsoId("_zSz2of9jEea3W_f2lS_aiw")]
    [DisplayName("Unit")]
    public record Unit : FinancialInstrumentQuantity30Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
        public required IsoLongFraction21DecimalNumber Value { get; init; }
    }
}
