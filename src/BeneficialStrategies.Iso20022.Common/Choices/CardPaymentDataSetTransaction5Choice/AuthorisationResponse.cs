// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction5Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_Cc49Q6p3EeanIZ10Ka8PnA")]
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction5Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_r17-gap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_r17-g6p2EeanIZ10Ka8PnA")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_r17-hap2EeanIZ10Ka8PnA")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment66 Environment { get; init; }

        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_r17-h6p2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction78 Transaction { get; init; }

        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_r17-iap2EeanIZ10Ka8PnA")]
        [DisplayName("Transaction Response")]
        [IsoXmlTag("TxRspn")]
        public required CardPaymentTransaction67 TransactionResponse { get; init; }
    }
}
