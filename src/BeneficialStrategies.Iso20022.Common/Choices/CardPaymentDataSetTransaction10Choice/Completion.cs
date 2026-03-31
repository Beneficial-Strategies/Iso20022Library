// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_bgZKsU0ZEeybj420QgWBkA")]
    [DisplayName("Completion")]
    [IsoXmlTag("Cmpltn")]
    public record Completion : CardPaymentDataSetTransaction10Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_yMu5QU6ZEeyGi9JAv6wq7Q")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_yMu5Q06ZEeyGi9JAv6wq7Q")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability8? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_yMu5RU6ZEeyGi9JAv6wq7Q")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment78 Environment { get; init; }

        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_yMu5R06ZEeyGi9JAv6wq7Q")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext29? Context { get; init; }

        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_yMu5SU6ZEeyGi9JAv6wq7Q")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction118 Transaction { get; init; }
    }
}
