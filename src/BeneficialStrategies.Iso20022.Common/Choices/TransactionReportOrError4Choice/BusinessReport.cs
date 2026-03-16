// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionReportOrError4Choice
{
    /// <summary>
    /// Reports on payment transactions.
    /// </summary>
    [IsoId("_WnqHQW49EeiU9cctagi5ow")]
    [DisplayName("Business Report")]
    public record BusinessReport : TransactionReportOrError4Choice_
    {
        /// <summary>
        /// Common detailed payment instruction information.
        /// </summary>
        [IsoId("_WxDT2W49EeiU9cctagi5ow")]
        [DisplayName("Payment Common Information")]
        [IsoXmlTag("PmtCmonInf")]
        public PaymentCommon4? PaymentCommonInformation { get; init; }

        /// <summary>
        /// Indicates the total number and sum of the transactions.
        /// </summary>
        [IsoId("_WxDT2249EeiU9cctagi5ow")]
        [DisplayName("Transactions Summary")]
        [IsoXmlTag("TxsSummry")]
        public NumberAndSumOfTransactions2? TransactionsSummary { get; init; }

        /// <summary>
        /// Reports either on the transaction information or on a business error.
        /// </summary>
        [IsoId("_WxDT3W49EeiU9cctagi5ow")]
        [DisplayName("Transaction Report")]
        [IsoXmlTag("TxRpt")]
        public ValueList<TransactionReport5> TransactionReport { get; init; } = [];
        // ID for the above is _WxDT3W49EeiU9cctagi5ow
    }
}
