// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity20Choice
{
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
    /// </summary>
    [IsoId("_pPlzTwFIEeGhYJiRaPcH8g")]
    [DisplayName("Amortised Value")]
    public record AmortisedValue : FinancialInstrumentQuantity20Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
