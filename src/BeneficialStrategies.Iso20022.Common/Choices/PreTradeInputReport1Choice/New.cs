// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PreTradeInputReport1Choice
{
    /// <summary>Pre-trade input related data report.</summary>
    [IsoId("_RroN0GF9EfC07JR6e2JJ-w")]
    [DisplayName("New")]
    public record New : PreTradeInputReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("New")]
        public required PreTradeInputReport1 Value { get; init; }
    }
}
