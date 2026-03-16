// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError5Choice
{
    /// <summary>
    /// Reports on payment transactions.
    /// </summary>
    [IsoId("_df3BIdcZEeqRFcf2R4bPBw")]
    [DisplayName("Business Report")]
    [IsoXmlTag("BizRpt")]
    public record BusinessReport : TransactionReportOrError5Choice_
    {
        /// <summary>
        /// Common detailed payment instruction information.
        /// </summary>
        [IsoId("_dhhOB9cZEeqRFcf2R4bPBw")]
        [DisplayName("Payment Common Information")]
        [IsoXmlTag("PmtCmonInf")]
        public PaymentCommon5? PaymentCommonInformation { get; init; }

        /// <summary>
        /// Indicates the total number and sum of the transactions.
        /// </summary>
        [IsoId("_dhhOCdcZEeqRFcf2R4bPBw")]
        [DisplayName("Transactions Summary")]
        [IsoXmlTag("TxsSummry")]
        public NumberAndSumOfTransactions2? TransactionsSummary { get; init; }

        /// <summary>
        /// Reports either on the transaction information or on a business error.
        /// </summary>
        [IsoId("_dhhOC9cZEeqRFcf2R4bPBw")]
        [DisplayName("Transaction Report")]
        [IsoXmlTag("TxRpt")]
        public ValueList<TransactionReport6> TransactionReport { get; init; } = [];
        // ID for the above is _dhhOC9cZEeqRFcf2R4bPBw
    }
}
