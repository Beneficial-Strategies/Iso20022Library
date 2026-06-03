// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>Specifies the from to quantity range.</summary>
    [IsoId("_jtRfEu5NEeCisYr99QEiWA_-1639886527")]
    [DisplayName("From To Quantity")]
    public record FromToQuantity : QuantityRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("FrToQty")]
        public required FromToQuantityRange1 Value { get; init; }
    }
}
