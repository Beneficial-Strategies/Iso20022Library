// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_3c5dMNuREeiB5uLfkg9ZJA")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public record PaymentRequest : TransactionToPerform1Choice_
    {
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_iOcdENt-EeiXqq0XHEoNUA")]
        [DisplayName("Payment Transaction")]
        [IsoXmlTag("PmtTx")]
        public CardPaymentTransaction91? PaymentTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_6xSugNuDEeiXqq0XHEoNUA")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData1? LoyaltyData { get; init; }
    }
}
