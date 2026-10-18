// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the counterparty market infrastructure transaction identification.</summary>
    [IsoId("_btDt8KgzEfCXwLUUylXgrQ")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    public partial record CounterpartyMarketInfrastructureTransactionIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
        public required Max35Text Value { get; init; }
    }
}
