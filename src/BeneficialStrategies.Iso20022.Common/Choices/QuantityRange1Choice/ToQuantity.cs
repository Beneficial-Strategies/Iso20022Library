// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>Specifies the to quantity.</summary>
    [IsoId("_jtRfEe5NEeCisYr99QEiWA_44952824")]
    [DisplayName("To Quantity")]
    public record ToQuantity : QuantityRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("ToQty")]
        public required QuantityRangeBoundary1 Value { get; init; }
    }
}
