// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <inheritdoc cref="ICounterpartyMarketInfrastructureTransactionIdentification"/>
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    public partial record CounterpartyMarketInfrastructureTransactionIdentification : References80Choice_
    {
        /// <inheritdoc cref="ICounterpartyMarketInfrastructureTransactionIdentification.Value"/>
        [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
