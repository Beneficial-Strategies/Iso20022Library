// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the market infrastructure transaction identification.</summary>
    [IsoId("_4SiC0eSlEe-qVZLXW4RRBw")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    public record MarketInfrastructureTransactionIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
