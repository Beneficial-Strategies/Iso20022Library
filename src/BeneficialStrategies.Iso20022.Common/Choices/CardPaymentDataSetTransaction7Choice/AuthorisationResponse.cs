// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction7Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_438Td9eiEeiJyp_aycJaTw")]
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction7Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_hsaA8deiEeiJyp_aycJaTw")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_hsaA89eiEeiJyp_aycJaTw")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_hsaA9deiEeiJyp_aycJaTw")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment69 Environment { get; init; }

        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_hsaA99eiEeiJyp_aycJaTw")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction90 Transaction { get; init; }

        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_hsaA-deiEeiJyp_aycJaTw")]
        [DisplayName("Transaction Response")]
        [IsoXmlTag("TxRspn")]
        public required CardPaymentTransaction84 TransactionResponse { get; init; }
    }
}
