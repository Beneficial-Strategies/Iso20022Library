// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the market infrastructure transaction identification.</summary>
    [IsoId("910139b7-5f84-4d8b-bcac-56e2acb9051a")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    public record MarketInfrastructureTransactionIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
