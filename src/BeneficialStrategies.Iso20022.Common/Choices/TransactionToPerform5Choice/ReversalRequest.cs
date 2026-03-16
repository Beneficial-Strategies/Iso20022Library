// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform5Choice
{
    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [IsoId("_Xt0vFXGwEe2TbaNWBpRZpQ")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public record ReversalRequest : TransactionToPerform5Choice_
    {
        /// <summary>
        /// Transaction to reverse.
        /// </summary>
        [IsoId("_XC8GYXGtEe2TbaNWBpRZpQ")]
        [DisplayName("Reversal Transaction")]
        [IsoXmlTag("RvslTx")]
        public CardPaymentTransaction127? ReversalTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_XC8GY3GtEe2TbaNWBpRZpQ")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData3? LoyaltyData { get; init; }

        /// <summary>
        /// Reason for this reversal.
        /// </summary>
        [IsoId("_XC8GZXGtEe2TbaNWBpRZpQ")]
        [DisplayName("Reversal Reason")]
        [IsoXmlTag("RvslRsn")]
        public required ReversalReason1Code ReversalReason { get; init; }

        /// <summary>
        /// Amount to reverse (total or partial).
        /// </summary>
        [IsoId("_XC8GZ3GtEe2TbaNWBpRZpQ")]
        [DisplayName("Reversed Amount")]
        [IsoXmlTag("RvsdAmt")]
        public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

        /// <summary>
        /// Specific Customer Order linked with the reversal.
        /// </summary>
        [IsoId("_XC8GaXGtEe2TbaNWBpRZpQ")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }
    }
}
