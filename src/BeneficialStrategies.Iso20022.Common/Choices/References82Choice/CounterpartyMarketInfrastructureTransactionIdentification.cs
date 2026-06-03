// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the counterparty market infrastructure transaction identification.</summary>
    [IsoId("_ujtNAeSlEe-qVZLXW4RRBw")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    public record CounterpartyMarketInfrastructureTransactionIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
