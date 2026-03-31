// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity45Choice
{
    /// <summary>
    /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
    /// </summary>
    [IsoId("_C_3YETRAEe2id-MjcNoBdw")]
    [DisplayName("Digital Token Unit")]
    public record DigitalTokenUnit : FinancialInstrumentQuantity45Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6 with a maximum of 30 digits and 29 fraction digits.
        /// </summary>
        [IsoXmlTag("DgtlTknUnit")]
        [IsoSimpleType(IsoSimpleType.Max30DecimalNumber)]
        public required IsoMax30DecimalNumber Value { get; init; }
    }
}
