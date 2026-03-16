// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction3Choice
{
    /// <summary>
    /// Cancelled card payment transaction to be captured.
    /// </summary>
    [IsoId("_EzeIQ2mJEeS7iYydEtv3Ug")]
    [DisplayName("Cancellation")]
    public record Cancellation : CardPaymentDataSetTransaction3Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_f8cOwWmLEeS7iYydEtv3Ug")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_f8cOw2mLEeS7iYydEtv3Ug")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability2? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the cancelled transaction captured in batch.
        /// </summary>
        [IsoId("_f8cOxWmLEeS7iYydEtv3Ug")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment40 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_f8cOx2mLEeS7iYydEtv3Ug")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext13? Context { get; init; }

        /// <summary>
        /// Card payment cancellation transaction between an acceptor and an acquirer.
        /// </summary>
        [IsoId("_f8cOyWmLEeS7iYydEtv3Ug")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction46 Transaction { get; init; }
    }
}
