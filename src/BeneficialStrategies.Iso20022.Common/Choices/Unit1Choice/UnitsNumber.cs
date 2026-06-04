// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Unit1Choice
{
    /// <summary>Quantity expressed as a number of units.</summary>
    [IsoId("95fcab82-8696-4195-8d32-436e0645910b")]
    [DisplayName("Units Number")]
    public record UnitsNumber : Unit1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UnitsNb")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
