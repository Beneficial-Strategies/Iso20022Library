// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_3c5dMNuREeiB5uLfkg9ZJA")]
    [DisplayName("Payment Request")]
    public partial record PaymentRequest : TransactionToPerform1Choice_
    {
        #nullable enable
        
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
        
        
        #nullable disable
        
    }
}
