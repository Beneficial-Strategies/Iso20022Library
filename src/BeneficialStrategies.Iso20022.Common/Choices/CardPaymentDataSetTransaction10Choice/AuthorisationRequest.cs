// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_bgZKtU0ZEeybj420QgWBkA")]
    [DisplayName("Authorisation Request")]
    public record AuthorisationRequest : CardPaymentDataSetTransaction10Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_9B_DQU3jEey_VecAUE-C9Q")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_9B_DQ03jEey_VecAUE-C9Q")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability8? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_9B_DRU3jEey_VecAUE-C9Q")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment78 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_9B_DR03jEey_VecAUE-C9Q")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext29? Context { get; init; }

        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_9B_DSU3jEey_VecAUE-C9Q")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction119 Transaction { get; init; }
    }
}
