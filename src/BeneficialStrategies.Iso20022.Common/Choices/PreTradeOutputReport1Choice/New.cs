// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PreTradeOutputReport1Choice
{
    /// <summary>Pre-trade output related data report.</summary>
    [IsoId("_kDbIcGIVEfCeoPFCHQnhvA")]
    [DisplayName("New")]
    public record New : PreTradeOutputReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("New")]
        public required PreTradeOutputReport1 Value { get; init; }
    }
}
