// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform3Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_xaZiUS8QEeu125Ip9zFcsQ")]
    [DisplayName("Payment Request")]
    public partial record PaymentRequest : TransactionToPerform3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_7oeOIS83Eeu125Ip9zFcsQ")]
        [DisplayName("Payment Transaction")]
        [IsoXmlTag("PmtTx")]
        public CardPaymentTransaction110? PaymentTransaction { get; init; } 
        
        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_7oeOIy83Eeu125Ip9zFcsQ")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData2? LoyaltyData { get; init; } 
        
        
        #nullable disable
        
    }
}
