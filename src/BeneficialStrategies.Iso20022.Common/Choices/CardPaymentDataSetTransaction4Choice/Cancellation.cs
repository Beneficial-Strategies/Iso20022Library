// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction4Choice
{
    /// <summary>
    /// Cancelled card payment transaction to be captured.
    /// </summary>
    [IsoId("_U0k2o43MEeWjkqXgn_0Imw")]
    [DisplayName("Cancellation")]
    public record Cancellation : CardPaymentDataSetTransaction4Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_HlYKEY3PEeWjkqXgn_0Imw")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_HlYKE43PEeWjkqXgn_0Imw")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the cancelled transaction captured in batch.
        /// </summary>
        [IsoId("_HlYKFY3PEeWjkqXgn_0Imw")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment52 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_HlYKF43PEeWjkqXgn_0Imw")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext19? Context { get; init; }

        /// <summary>
        /// Card payment cancellation transaction between an acceptor and an acquirer.
        /// </summary>
        [IsoId("_HlYKGY3PEeWjkqXgn_0Imw")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction61 Transaction { get; init; }
    }
}
