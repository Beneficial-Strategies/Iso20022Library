// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantityChoice
{
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, eg, a periodic reduction of a bond&apos;s principal amount.
    /// </summary>
    [IsoId("_SoH20Np-Ed-ak6NoX_4Aeg_1583790695")]
    [DisplayName("Amortised Value")]
    public record AmortisedValue : FinancialInstrumentQuantityChoice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtsdVal")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
