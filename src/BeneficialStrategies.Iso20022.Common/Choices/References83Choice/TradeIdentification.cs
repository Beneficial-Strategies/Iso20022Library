// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the trade identification.</summary>
    [IsoId("_Wt0M6KgzEfCXwLUUylXgrQ")]
    [DisplayName("Trade Identification")]
    public record TradeIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TradId")]
        public required IsoMax35Text Value { get; init; }
    }
}
