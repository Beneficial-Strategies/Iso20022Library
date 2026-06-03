// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>Specifies the not equal quantity.</summary>
    [IsoId("_jtRfFO5NEeCisYr99QEiWA_-267876901")]
    [DisplayName("Not Equal Quantity")]
    public record NotEqualQuantity : QuantityRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NEQQty")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
