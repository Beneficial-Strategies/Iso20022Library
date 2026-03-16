// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction10Choice
{
    /// <summary>
    /// Response to a token computation.
    /// </summary>
    [IsoId("_bgZKu00ZEeybj420QgWBkA")]
    [DisplayName("Token Response")]
    public record TokenResponse : CardPaymentDataSetTransaction10Choice_
    {
        /// <summary>
        /// Identification of an element in a sequence.
        /// </summary>
        [IsoId("__J2_wU7VEeyGi9JAv6wq7Q")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Environment of the transaction.
        /// </summary>
        [IsoId("__J2_w07VEeyGi9JAv6wq7Q")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment78 Environment { get; init; }
    }
}
