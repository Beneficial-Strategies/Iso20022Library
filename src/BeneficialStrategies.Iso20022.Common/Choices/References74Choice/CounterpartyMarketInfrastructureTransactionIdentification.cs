// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice
{
    /// <inheritdoc cref="ICounterpartyMarketInfrastructureTransactionIdentification"/>
    [IsoId("_PENYcSgaEey2k_sfZmJz4g")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    public partial record CounterpartyMarketInfrastructureTransactionIdentification : References74Choice_
    {
        /// <inheritdoc cref="ICounterpartyMarketInfrastructureTransactionIdentification.Value"/>
        [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
