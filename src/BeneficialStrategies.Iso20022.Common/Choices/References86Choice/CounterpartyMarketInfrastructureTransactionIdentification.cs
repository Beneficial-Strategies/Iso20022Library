// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the counterparty market infrastructure transaction identification.</summary>
    [IsoId("1823c627-98b8-4eab-8e05-995eb001b895")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    public record CounterpartyMarketInfrastructureTransactionIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
