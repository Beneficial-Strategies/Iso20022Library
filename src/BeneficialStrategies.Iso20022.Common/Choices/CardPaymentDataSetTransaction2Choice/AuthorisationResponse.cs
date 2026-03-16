// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction2Choice
{
    /// <summary>
    /// Card payment transaction including an authorisation response.
    /// </summary>
    [IsoId("_RPup9zKQEeOqyZqt0rCZLg")]
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction2Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_6ht2YTKOEeOqyZqt0rCZLg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_6ht2YzKOEeOqyZqt0rCZLg")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability1? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the card payment transaction.
        /// </summary>
        [IsoId("_6ht2ZTKOEeOqyZqt0rCZLg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment28 Environment { get; init; }

        /// <summary>
        /// Card payment transaction authorisation result.
        /// </summary>
        [IsoId("_6ht2ZzKOEeOqyZqt0rCZLg")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction32 Transaction { get; init; }

        /// <summary>
        /// Response to the authorisation request from the acquirer.
        /// </summary>
        [IsoId("_6ht2aTKOEeOqyZqt0rCZLg")]
        [DisplayName("Transaction Response")]
        [IsoXmlTag("TxRspn")]
        public required CardPaymentTransaction24 TransactionResponse { get; init; }
    }
}
