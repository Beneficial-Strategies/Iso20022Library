// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity5Choice
{
    /// <summary>
    /// Percentage of the total switch amount (buy-driven) to be invested in a particular investment fund or investment fund class.
    /// </summary>
    [IsoId("_Soaxw9p-Ed-ak6NoX_4Aeg_1036645905")]
    [DisplayName("Percentage Of Total Subscription Amount")]
    public record PercentageOfTotalSubscriptionAmount : FinancialInstrumentQuantity5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
        /// </summary>
        [IsoXmlTag("PctgOfTtlSbcptAmt")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
