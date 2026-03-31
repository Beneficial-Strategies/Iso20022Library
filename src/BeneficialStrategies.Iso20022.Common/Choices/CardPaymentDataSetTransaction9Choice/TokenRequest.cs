// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice
{
    /// <summary>
    /// Request for a token computation.
    /// </summary>
    [IsoId("_Qd_6MC_2EeugIJ3Gvoevmg")]
    [DisplayName("Token Request")]
    [IsoXmlTag("TknReq")]
    public record TokenRequest : CardPaymentDataSetTransaction9Choice_
    {
        /// <summary>
        /// Identification of an element in a sequence.
        /// </summary>
        [IsoId("_8UVdQC_1EeugIJ3Gvoevmg")]
        [DisplayName("Transaction Sequence Counter")]
        [IsoXmlTag("TxSeqCntr")]
        [IsoSimpleType(IsoSimpleType.Max9NumericText)]
        public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

        /// <summary>
        /// Environment of the transaction.
        /// </summary>
        [IsoId("_-Is94S_1EeugIJ3Gvoevmg")]
        [DisplayName("Environment")]
        [IsoXmlTag("Envt")]
        public required CardPaymentEnvironment77 Environment { get; init; }
    }
}
