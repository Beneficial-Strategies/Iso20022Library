// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the market infrastructure transaction identification.</summary>
    [IsoId("_Wt0MzqgzEfCXwLUUylXgrQ")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    public record MarketInfrastructureTransactionIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
