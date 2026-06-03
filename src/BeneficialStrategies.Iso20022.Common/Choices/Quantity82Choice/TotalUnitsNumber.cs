// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Quantity82Choice
{
    /// <summary>Specifies the total units number.</summary>
    [IsoId("9f2b4cc0-595f-4fb1-a54f-20fc6fc673c8")]
    [DisplayName("Total Units Number")]
    public record TotalUnitsNumber : Quantity82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TtlUnitsNb")]
        public required Unit1Choice_ Value { get; init; }
    }
}
