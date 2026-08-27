// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CashType1Choice
{
    /// <summary>Cash type as published in an external cash type code set.</summary>
    [IsoId("_R9pcZVDeEfCRhs5qxCujTw")]
    [DisplayName("Code")]
    public record Code : CashType1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalCashType1Code Value { get; init; }
    }
}
