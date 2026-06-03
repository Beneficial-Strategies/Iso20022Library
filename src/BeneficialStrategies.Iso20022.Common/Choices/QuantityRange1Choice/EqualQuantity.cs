// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>Specifies the equal quantity.</summary>
    [IsoId("_jtRfE-5NEeCisYr99QEiWA_-675705255")]
    [DisplayName("Equal Quantity")]
    public record EqualQuantity : QuantityRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("EQQty")]
        public required IsoDecimalNumber Value { get; init; }
    }
}
