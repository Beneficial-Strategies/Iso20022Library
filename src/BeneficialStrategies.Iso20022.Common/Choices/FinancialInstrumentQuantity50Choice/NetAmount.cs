// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Quantity expressed as a net amount of money.</summary>
    [IsoId("b342be83-12bf-4afc-ae13-c47d3d5bfafb")]
    [DisplayName("Net Amount")]
    public record NetAmount : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NetAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
