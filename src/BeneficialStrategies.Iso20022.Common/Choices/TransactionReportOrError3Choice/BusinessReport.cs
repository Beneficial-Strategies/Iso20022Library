// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError3Choice
{
    /// <summary>
    /// Reports on payment transactions.
    /// </summary>
    [IsoId("_M4MEoZlPEee-Zps0fZQaFQ")]
    [DisplayName("Business Report")]
    public record BusinessReport : TransactionReportOrError3Choice_
    {
        /// <summary>
        /// Common detailed payment instruction information.
        /// </summary>
        [IsoId("_NAXwSZlPEee-Zps0fZQaFQ")]
        [DisplayName("Payment Common Information")]
        [IsoXmlTag("PmtCmonInf")]
        public PaymentCommon3? PaymentCommonInformation { get; init; }

        /// <summary>
        /// Indicates the total number and sum of the transactions.
        /// </summary>
        [IsoId("_NAXwS5lPEee-Zps0fZQaFQ")]
        [DisplayName("Transactions Summary")]
        [IsoXmlTag("TxsSummry")]
        public NumberAndSumOfTransactions2? TransactionsSummary { get; init; }

        /// <summary>
        /// Reports either on the transaction information or on a business error.
        /// </summary>
        [IsoId("_NAXwTZlPEee-Zps0fZQaFQ")]
        [DisplayName("Transaction Report")]
        [IsoXmlTag("TxRpt")]
        public ValueList<TransactionReport4> TransactionReport { get; init; } = [];
        // ID for the above is _NAXwTZlPEee-Zps0fZQaFQ
    }
}
