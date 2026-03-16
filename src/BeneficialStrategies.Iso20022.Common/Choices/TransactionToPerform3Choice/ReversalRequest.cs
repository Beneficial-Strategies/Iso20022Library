// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform3Choice
{
    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [IsoId("_xaZiVS8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public record ReversalRequest : TransactionToPerform3Choice_
    {
        /// <summary>
        /// Transaction to reverse.
        /// </summary>
        [IsoId("_ah5gkS8QEeu125Ip9zFcsQ")]
        [DisplayName("Reversal Transaction")]
        [IsoXmlTag("RvslTx")]
        public CardPaymentTransaction110? ReversalTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_IS6LIS8REeu125Ip9zFcsQ")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData2? LoyaltyData { get; init; }

        /// <summary>
        /// Reason for this reversal.
        /// </summary>
        [IsoId("_ah5gky8QEeu125Ip9zFcsQ")]
        [DisplayName("Reversal Reason")]
        [IsoXmlTag("RvslRsn")]
        public required ReversalReason1Code ReversalReason { get; init; }

        /// <summary>
        /// Amount to reverse (total or partial).
        /// </summary>
        [IsoId("_ah5glS8QEeu125Ip9zFcsQ")]
        [DisplayName("Reversed Amount")]
        [IsoXmlTag("RvsdAmt")]
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

        /// <summary>
        /// Specific Customer Order linked with the reversal.
        /// </summary>
        [IsoId("_ah5gly8QEeu125Ip9zFcsQ")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }
    }
}
