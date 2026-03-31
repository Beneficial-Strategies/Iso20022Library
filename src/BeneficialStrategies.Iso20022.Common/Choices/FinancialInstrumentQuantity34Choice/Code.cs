// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity34Choice
{
    /// <summary>
    /// Quantity expressed as a code.
    /// </summary>
    [IsoId("_lhWKOxu0EeyhRdHRjakS2w")]
    [DisplayName("Code")]
    public record Code : FinancialInstrumentQuantity34Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies quantity of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Quantity4Code Value { get; init; }
    }
}
