// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity50Choice
{
    /// <summary>Quantity expressed as a gross amount of money.</summary>
    [IsoId("8c905f4b-b475-4a91-95f2-a60f1e738881")]
    [DisplayName("Gross Amount")]
    public record GrossAmount : FinancialInstrumentQuantity50Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GrssAmt")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
