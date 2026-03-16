// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction5Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation request.
    /// </summary>
    [IsoId("_Cc49Qap3EeanIZ10Ka8PnA")]
    [DisplayName("Authorisation Request")]
    [IsoXmlTag("AuthstnReq")]
    public record AuthorisationRequest : CardPaymentDataSetTransaction5Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_mi-3Iap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_mi-3I6p2EeanIZ10Ka8PnA")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction to authorise.
        /// </summary>
        [IsoId("_mi-3Jap2EeanIZ10Ka8PnA")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment62 Environment { get; init; }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [IsoId("_mi-3J6p2EeanIZ10Ka8PnA")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext24? Context { get; init; }

        /// <summary>
        /// Card payment transaction to authorise.
        /// </summary>
        [IsoId("_mi-3Kap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction71 Transaction { get; init; }
    }
}
