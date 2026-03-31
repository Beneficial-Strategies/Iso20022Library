// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform5Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_Xt0vEXGwEe2TbaNWBpRZpQ")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public record PaymentRequest : TransactionToPerform5Choice_
    {
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_kd-koXGsEe2TbaNWBpRZpQ")]
        [DisplayName("Payment Transaction")]
        [IsoXmlTag("PmtTx")]
        public CardPaymentTransaction127? PaymentTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_kd-ko3GsEe2TbaNWBpRZpQ")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData3? LoyaltyData { get; init; }
    }
}
