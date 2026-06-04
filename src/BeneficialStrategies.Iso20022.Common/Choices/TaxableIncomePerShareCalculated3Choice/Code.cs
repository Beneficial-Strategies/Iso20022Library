// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculated3Choice
{
    /// <summary>Taxable income per share calculated expressed as a code.</summary>
    [IsoId("6fead324-a1cb-4635-a170-90182b1d4a84")]
    [DisplayName("Code")]
    public record Code : TaxableIncomePerShareCalculated3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required TaxableIncomePerShareCalculated2Code Value { get; init; }
    }
}
