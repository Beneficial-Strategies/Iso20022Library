// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CashType1Choice
{
    /// <summary>Cash type, in a proprietary form.</summary>
    [IsoId("_R9pcZFDeEfCRhs5qxCujTw")]
    [DisplayName("Proprietary")]
    public record Proprietary : CashType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
