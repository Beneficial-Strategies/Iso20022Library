// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_KV7CRS5BEeunNvJlR_vCbg")]
    [DisplayName("Authorisation Request")]
    public record AuthorisationRequest : CardPaymentDataSetTransaction9Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_CbFLQS5EEeunNvJlR_vCbg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_CbFLQy5EEeunNvJlR_vCbg")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability8? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_CbFLRS5EEeunNvJlR_vCbg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment77 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_CbFLRy5EEeunNvJlR_vCbg")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext28? Context { get; init; }

        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_CbFLSS5EEeunNvJlR_vCbg")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction107 Transaction { get; init; }
    }
}
