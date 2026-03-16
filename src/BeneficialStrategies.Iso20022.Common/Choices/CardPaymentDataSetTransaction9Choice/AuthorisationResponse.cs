// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_KV7CRy5BEeunNvJlR_vCbg")]
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction9Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_rnTpwS5JEeunNvJlR_vCbg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_rnTpwy5JEeunNvJlR_vCbg")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability8? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_rnTpxS5JEeunNvJlR_vCbg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment77 Environment { get; init; }

        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_rnTpxy5JEeunNvJlR_vCbg")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction111 Transaction { get; init; }

        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_rnTpyS5JEeunNvJlR_vCbg")]
        [DisplayName("Transaction Response")]
        [IsoXmlTag("TxRspn")]
        public required CardPaymentTransaction109 TransactionResponse { get; init; }
    }
}
