// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform4Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_8yJLQU31Eey_VecAUE-C9Q")]
    [DisplayName("Payment Request")]
    public record PaymentRequest : TransactionToPerform4Choice_
    {
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_UtDIYU36Eey_VecAUE-C9Q")]
        [DisplayName("Payment Transaction")]
        [IsoXmlTag("PmtTx")]
        public CardPaymentTransaction120? PaymentTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_UtDIY036Eey_VecAUE-C9Q")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData3? LoyaltyData { get; init; }
    }
}
