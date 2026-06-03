// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>Specifies the from quantity.</summary>
    [IsoId("_jtRfEO5NEeCisYr99QEiWA_-377163681")]
    [DisplayName("From Quantity")]
    public record FromQuantity : QuantityRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrQty")]
        public required QuantityRangeBoundary1 Value { get; init; }
    }
}
