// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculated3Choice
{
    /// <summary>Taxable income per share calculated expressed as a proprietary code.</summary>
    [IsoId("9b8738fe-8173-4ffc-ac40-2f21598ff8f4")]
    [DisplayName("Proprietary")]
    public record Proprietary : TaxableIncomePerShareCalculated3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
