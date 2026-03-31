// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction6Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_aCXvYdpoEeearpaEPXv9UA")]
    [DisplayName("Completion")]
    [IsoXmlTag("Cmpltn")]
    public record Completion : CardPaymentDataSetTransaction6Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_Ouj40dpoEeearpaEPXv9UA")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_Ouj409poEeearpaEPXv9UA")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability5? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_Ouj41dpoEeearpaEPXv9UA")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment68 Environment { get; init; }

        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_Ouj419poEeearpaEPXv9UA")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext26? Context { get; init; }

        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_Ouj42dpoEeearpaEPXv9UA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction81 Transaction { get; init; }
    }
}
