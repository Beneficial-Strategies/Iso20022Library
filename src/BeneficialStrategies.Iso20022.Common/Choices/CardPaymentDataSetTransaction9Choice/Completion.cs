// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice
{
    /// <summary>
    /// Completed card payment transaction to be captured.
    /// </summary>
    [IsoId("_KV7CQS5BEeunNvJlR_vCbg")]
    [DisplayName("Completion")]
    [IsoXmlTag("Cmpltn")]
    public record Completion : CardPaymentDataSetTransaction9Choice_
    {
        /// <summary>
        /// Sequential counter of the transaction.
        /// </summary>
        [IsoId("_Fbhk0S5BEeunNvJlR_vCbg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
        /// </summary>
        [IsoId("_Fbhk0y5BEeunNvJlR_vCbg")]
        [DisplayName("Traceability")]
        [IsoXmlTag("Tracblt")]
        public Traceability8? Traceability { get; init; }

        /// <summary>
        /// Data related to the environment of the transaction in a transaction captured in batch.
        /// </summary>
        [IsoId("_Fbhk1S5BEeunNvJlR_vCbg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment77 Environment { get; init; }

        /// <summary>
        /// Data related to the context of the transaction.
        /// </summary>
        [IsoId("_Fbhk1y5BEeunNvJlR_vCbg")]
        [DisplayName("Context")]
        [IsoXmlTag("Cntxt")]
        public CardPaymentContext28? Context { get; init; }

        /// <summary>
        /// Transaction information to be captured.
        /// </summary>
        [IsoId("_Fbhk2S5BEeunNvJlR_vCbg")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required CardPaymentTransaction103 Transaction { get; init; }
    }
}
