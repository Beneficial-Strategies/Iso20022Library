// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradingSystemReport1Choice
{
    /// <summary>Trading system related data report.</summary>
    [IsoId("_EdSKwGFdEfC-1NkZ9TkdKA")]
    [DisplayName("New")]
    public record New : TradingSystemReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("New")]
        public required TradingSystemReport1 Value { get; init; }
    }
}
