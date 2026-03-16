// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice
{
    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [IsoId("_8caEINuREeiB5uLfkg9ZJA")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public record ReversalRequest : TransactionToPerform1Choice_
    {
        /// <summary>
        /// Original transaction to reverse.
        /// </summary>
        [IsoId("_kIAtINuGEeiB5uLfkg9ZJA")]
        [DisplayName("Original Payment Transaction")]
        [IsoXmlTag("OrgnlPmtTx")]
        public CardPaymentTransaction91? OriginalPaymentTransaction { get; init; }

        /// <summary>
        /// Reason for this reversal.
        /// </summary>
        [IsoId("_pHwkoNuGEeiB5uLfkg9ZJA")]
        [DisplayName("Reversal Reason")]
        [IsoXmlTag("RvslRsn")]
        public required ReversalReason1Code ReversalReason { get; init; }

        /// <summary>
        /// Amount to reverse (total or partial).
        /// </summary>
        [IsoId("_OsLBMNuHEeiB5uLfkg9ZJA")]
        [DisplayName("Reversed Amount")]
        [IsoXmlTag("RvsdAmt")]
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

        /// <summary>
        /// Specific Customer Order linked with the reversal.
        /// </summary>
        [IsoId("_SDiloNuHEeiB5uLfkg9ZJA")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }
    }
}
