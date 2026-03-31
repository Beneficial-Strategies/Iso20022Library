// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction4Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_U0k2p43MEeWjkqXgn_0Imw")]
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction4Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_ITgekY3TEeWjkqXgn_0Imw")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_ITgek43TEeWjkqXgn_0Imw")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_ITgelY3TEeWjkqXgn_0Imw")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment54 Environment { get; init; }

        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_ITgel43TEeWjkqXgn_0Imw")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction63 Transaction { get; init; }

        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_ITgemY3TEeWjkqXgn_0Imw")]
        [DisplayName("Transaction Response")]
        [IsoXmlTag("TxRspn")]
        public required CardPaymentTransaction54 TransactionResponse { get; init; }
    }
}
