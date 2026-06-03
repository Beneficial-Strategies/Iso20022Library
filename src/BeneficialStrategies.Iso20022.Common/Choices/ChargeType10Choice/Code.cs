// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType10Choice
{
    /// <summary>Fee (charge/commission) expressed as a code.</summary>
    [IsoId("128dd115-fcaf-4228-9621-441a7a659f6e")]
    [DisplayName("Code")]
    public record Code : ChargeType10Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundFee3Code Value { get; init; }
    }
}
