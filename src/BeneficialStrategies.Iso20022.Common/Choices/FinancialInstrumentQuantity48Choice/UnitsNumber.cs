// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity48Choice
{
    /// <summary>Number of investment fund units redeemed.</summary>
    [IsoId("0ffa4162-d088-4060-875f-ac0d58dc0fb2")]
    [DisplayName("Units Number")]
    public record UnitsNumber : FinancialInstrumentQuantity48Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UnitsNb")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
