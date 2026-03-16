// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction11Choice
{
    /// <summary>
    /// Request for a token computation.
    /// </summary>
    [IsoId("_1ylO2XJCEe299ZbWCkdR_w")]
    [DisplayName("Token Request")]
    public record TokenRequest : CardPaymentDataSetTransaction11Choice_
    {
        /// <summary>
        /// Identification of an element in a sequence.
        /// </summary>
        [IsoId("_-2bqYXJBEe299ZbWCkdR_w")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Environment of the transaction.
        /// </summary>
        [IsoId("_-2bqY3JBEe299ZbWCkdR_w")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment79 Environment { get; init; }
    }
}
